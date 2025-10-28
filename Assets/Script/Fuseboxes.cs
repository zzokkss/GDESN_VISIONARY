using UnityEngine;

public class Fuseboxes : MonoBehaviour
{
    //Variables
    bool inRange = false;

    //References
    [SerializeField] int fuseboxID;
    [SerializeField] GameObject mara;
    [SerializeField] GameObject maze;
    [SerializeField] Camera mazeCam;
    [SerializeField] Camera remCam;

    [SerializeField] RemMovement remMovement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("player movement disabled. opening puzzle...");
            mara.SetActive(true);
            maze.SetActive(true);
            mazeCam.gameObject.SetActive(true);
            remCam.gameObject.SetActive(false);
            remMovement.MinigameOpen();
        }
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inRange = true;
            Debug.Log("Player near fusebox");
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inRange = false;
            Debug.Log("Player left fusebox");
        }
    }
    
}
