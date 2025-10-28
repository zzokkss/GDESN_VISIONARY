using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpticUnits : MonoBehaviour
{
    //variables
    public float delay;
    Animator anim;

    [SerializeField] string sceneName; //the name of the scene we want to 
    float gameoverDelay = 0.5f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(DirectionTwo());
    }


    IEnumerator DirectionTwo()
    {
        yield return new WaitForSeconds(delay);
        anim.SetBool("directionOne", false);
        anim.SetBool("directionTwo", true);
        anim.SetBool("directionThree", false);
        StartCoroutine(DirectionThree());
    }

    IEnumerator DirectionThree()
    {
        yield return new WaitForSeconds(delay);
        anim.SetBool("directionOne", false);
        anim.SetBool("directionTwo", false);
        anim.SetBool("directionThree", true);
        StartCoroutine(DirectionOne());
    }
    IEnumerator DirectionOne()
    {
        yield return new WaitForSeconds(delay);
        anim.SetBool("directionOne", true);
        anim.SetBool("directionTwo", false);
        anim.SetBool("directionThree", false);
        StartCoroutine(DirectionTwo());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Found Player");
            StartCoroutine(GameOverDelay());
        }
    }

    IEnumerator GameOverDelay()
    {
        yield return new WaitForSeconds(gameoverDelay);
        SceneManager.LoadScene(sceneName);
    }
}
