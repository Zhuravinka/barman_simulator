using System;
using UnityEngine;

public class SwipeDetection : MonoBehaviour
{
    public static event Action<Vector2> Swiped = delegate { };

    private Vector2 _tapPoss;
    private Vector2 _swipeDelta;

    private float _deadZone = 30f;

    private bool isMobile;
    private bool isSwiping;

    private void Start()
    {
        isMobile = Application.isMobilePlatform;
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                isSwiping = true;
                _tapPoss = Input.GetTouch(0).position;
            }
            else if (Input.GetTouch(0).phase == TouchPhase.Canceled ||
                Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                ResetSwipe();
            }
        }

        CheckSwipe();
    }

    private void CheckSwipe()
    {
        _swipeDelta = Vector2.zero;

        if (isSwiping)
        {
            if (Input.touchCount > 0)
            {
                _swipeDelta = Input.GetTouch(0).position - _tapPoss;
            }
        }
        
        if (_swipeDelta.magnitude > _deadZone)
        {
            if (Mathf.Abs(_swipeDelta.x) > Mathf.Abs(_swipeDelta.y))
            {
                Debug.Log(_swipeDelta);
                Swiped(_swipeDelta.x > 0 ? Vector2.right : Vector2.left);
                ResetSwipe();
            }
        }
    }

    private void ResetSwipe()
    {
        isSwiping = false;
        _tapPoss = Vector2.zero;
        _swipeDelta = Vector2.zero;
    }
}
