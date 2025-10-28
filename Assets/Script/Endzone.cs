using System.Collections;
using UnityEngine;

public class Endzone : MonoBehaviour
{
    public int delay;

    [SerializeField] GameObject mara;
    [SerializeField] GameObject maze;
    [SerializeField] Camera mazeCam;
    [SerializeField] Camera remCam;
    [SerializeField] Camera lightCam;

    //to be destroyed
    [SerializeField] GameObject fusebox;
    [SerializeField] GameObject zoneLight;

    [SerializeField] RemMovement remMovement;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("MARA"))
        {
            Debug.Log("Player in Endzone");
            StartCoroutine (EndMinigame());
        }
    }

    IEnumerator EndMinigame()
    {
        yield return new WaitForSeconds(delay);
        mazeCam.gameObject.SetActive(false);
        lightCam.gameObject.SetActive(true);
        remMovement.MinigameClosed();
        Destroy(fusebox);
        StartCoroutine (DisableLight());
    }

    IEnumerator DisableLight()
    {
        yield return new WaitForSeconds(delay);
        Destroy(zoneLight);
        yield return new WaitForSeconds(delay);
        StartCoroutine(ToRem());
    }

    IEnumerator ToRem()
    {
        yield return new WaitForSeconds(delay);
        mara.SetActive(false);
        maze.SetActive(false);
        lightCam.gameObject.SetActive(false);
        remCam.gameObject.SetActive(true);
    }
}
