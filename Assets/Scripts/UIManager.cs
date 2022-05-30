using System.Linq;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private Window[] _windows;
    private void Awake()
    {
        _windows = GetComponentsInChildren<Window>();
        DontDestroyOnLoad(gameObject);
    }

    public void ShowWindow<T>() where T : Window
    {
        CloseWindows();
        var windowToShow = _windows.FirstOrDefault(x => x is T);
        windowToShow.Show();
    }

    private void CloseWindows()
    {
        foreach (var window in _windows)
        {
            window.Close();           
        }
    }
}
