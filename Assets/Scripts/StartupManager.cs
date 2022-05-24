using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartupManager : MonoBehaviour
{
    public const string StartupScene = "StartUp";

    public const string TutorialLevel = "SampleScene";

    IEnumerator Start()
    {
        DontDestroyOnLoad(gameObject);

        Application.targetFrameRate = 60;

        yield return StartCoroutine(LoadScene());

        Destroy(gameObject);
    }

    IEnumerator LoadScene()
    {
        yield return SceneManager.LoadSceneAsync(TutorialLevel);
    }
}