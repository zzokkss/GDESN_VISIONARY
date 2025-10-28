using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class InsideLight : MonoBehaviour
{
    [SerializeField] string sceneName; //the name of the scene we want to 
    float delay = 0.5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player in zone");
            StartCoroutine(GameOverDelay());
        }
    }

    IEnumerator GameOverDelay()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}
