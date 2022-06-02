using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartupManager : MonoBehaviour
{
    private const string StartupScene = "StartUp";

    private const string TutorialLevel = "BarCounter";

    private const string UIScene = "UI";

    IEnumerator Start()
    {
        DontDestroyOnLoad(gameObject);

        Application.targetFrameRate = 60;

        yield return StartCoroutine(LoadScene());

        Destroy(gameObject);
    }

    IEnumerator LoadScene()
    {
        yield return SceneManager.LoadSceneAsync(UIScene);

        yield return SceneManager.LoadSceneAsync(TutorialLevel);
    }
}