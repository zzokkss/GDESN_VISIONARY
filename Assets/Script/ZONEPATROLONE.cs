using System.Collections;
using UnityEngine;

public class ZONEPATROL : MonoBehaviour
{

    public float delay;
    [SerializeField] int patrolID;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(DirectionTwo());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DirectionTwo()
    {
        yield return new WaitForSeconds(delay);
        transform.Translate(2.5f, -2.5f, 0);
        StartCoroutine(DirectionThree());
    }

    IEnumerator DirectionThree()
    {
        yield return new WaitForSeconds(delay);
        transform.Translate(2.5f, 2.5f, 0);
        StartCoroutine(DirectionOne());
    }
    IEnumerator DirectionOne()
    {
        yield return new WaitForSeconds(delay);
        transform.Translate(-5f, 0, 0);
        StartCoroutine(DirectionTwo());
    }
}
