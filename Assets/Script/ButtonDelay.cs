using System.Collections;
using UnityEngine;

public class ButtonDelay : MonoBehaviour
{
    //THIS script is for the GameOver menu, specifically for the Main Menu button 

    [SerializeField] GameObject button;
    float delay = 4.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button.SetActive(false);
        StartCoroutine(ShowButtonDelay());
    }

    IEnumerator ShowButtonDelay()
    {
        yield return new WaitForSeconds(delay);
        button.SetActive(true);
    }

}
