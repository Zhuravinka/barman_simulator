using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartupManager : MonoBehaviour
{
    public const string StartupScene = "StartUp";

    public const string TutorialLevel = "SampleScene";

    public const string UIScene = "UI";

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