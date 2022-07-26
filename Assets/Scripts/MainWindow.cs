using System;
using UnityEngine;
using UnityEngine.UI;

public class MainWindow : Window
{
    public static event Action Started = delegate {  }; 

    [SerializeField]
    private Button _startGameButton = null;
    
    private void Start()
    {
        _startGameButton.onClick.AddListener(OnStartGameButtonClicked);
    }

    private void OnStartGameButtonClicked()
    {
        Started();
    }
}
