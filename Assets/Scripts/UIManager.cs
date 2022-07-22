using System.Linq;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private Window[] _windows;

    private void OnEnable()
    {
        MainWindow.Started += MainWindow_Started;
    }

    private void OnDisable()
    {
        MainWindow.Started -= MainWindow_Started;
    }
    
    private void Awake()
    {
        _windows = GetComponentsInChildren<Window>();
        ShowWindow<MainWindow>();
        DontDestroyOnLoad(gameObject);
    }
  
    private void CloseWindows()
    {
        foreach (var window in _windows)
        {
            window.Close();           
        }
    }
    
    public void ShowWindow<T>() where T : Window
    {
        CloseWindows();
        var windowToShow = _windows.FirstOrDefault(x => x is T);
        windowToShow.Show();
    }

    private void MainWindow_Started()
    {
        ShowWindow<GameWindow>();
    }
}
