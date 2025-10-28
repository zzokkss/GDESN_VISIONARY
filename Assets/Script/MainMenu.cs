using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] SpriteRenderer blackScreen;      
    [SerializeField] AudioSource audioSource;
    [SerializeField] float fadeDuration = 1f;
    [SerializeField] string sceneName; //the name of the scene we want to load

    public void StartGame()
    {
        StartCoroutine(FadeTransition());
    }

    IEnumerator FadeTransition()
    {
        float elapsed = 0f;
        Color panelColor = blackScreen.color;
        float startVolume = audioSource.volume;

        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;

            audioSource.volume = Mathf.Lerp(startVolume, 0f, elapsed / fadeDuration);

            panelColor.a = Mathf.Lerp(0f, 1f, elapsed / fadeDuration);
            blackScreen.color = panelColor;

            yield return null;
        }

        audioSource.volume = 0f;
        panelColor.a = 1f;
        blackScreen.color = panelColor;

        SceneManager.LoadScene(sceneName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
