using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ENDDOOR : MonoBehaviour
{
    [SerializeField] string sceneName; //the name of the scene we want to load
    [SerializeField] AudioSource audioSource;
    [SerializeField] float fadeDuration = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(EndGame());
        }
    }

    IEnumerator EndGame()
    {
        float elapsed = 0f;
        float startVolume = audioSource.volume;

        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;

            audioSource.volume = Mathf.Lerp(startVolume, 0f, elapsed / fadeDuration);

            yield return null;
        }

        audioSource.volume = 0f;
        SceneManager.LoadScene(sceneName);
    }
}
