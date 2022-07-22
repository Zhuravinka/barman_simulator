using UnityEngine;

public class GlassesSelect : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _glasses;

    private int _currentGlass;
    private bool isRight;
    private bool isLeft;

    private void OnEnable()
    {
        SwipeDetection.Swiped += SwipeDetection_Swiped;
    }

    private void OnDisable()
    {
        SwipeDetection.Swiped -= SwipeDetection_Swiped;
    }

    private void SwipeDetection_Swiped(Vector2 direction)
    {
        if (direction == Vector2.right)
        {
            if (_currentGlass == _glasses.Length - 1)
                return;

            _glasses[_currentGlass].SetActive(false);

            _currentGlass++;
            _glasses[_currentGlass].SetActive(true);
        }
        else if (direction == Vector2.left)
        {
            if (_currentGlass == 0)
                return;

            _glasses[_currentGlass].SetActive(false);

            _currentGlass--;
            _glasses[_currentGlass].SetActive(true);
        }
    }

    //public void Next()
    //{
    //    if (_currentGlass == _glasses.Length-1)
    //        return;
    //    Debug.Log("1");
    //    _glasses[_currentGlass].SetActive(false);

    //    _currentGlass++;
    //    _glasses[_currentGlass].SetActive(true);
    //}

    //public void Last()
    //{
    //    if (_currentGlass == 0)
    //        return;

    //    _glasses[_currentGlass].SetActive(false);

    //    _currentGlass--;
    //    _glasses[_currentGlass].SetActive(true);
    //}
}
