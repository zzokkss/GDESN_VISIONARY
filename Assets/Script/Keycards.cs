using UnityEngine;

public class Keycards : MonoBehaviour
{
    //Variables

    //References
    [SerializeField] int keycardID;
    [SerializeField] Animator anim;
    [SerializeField] string fragmentBoolName;
    float volume = 1.0f;

    [SerializeField] GameObject barrier;
    [SerializeField] AudioClip audioSource;
   
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
            //setting all bools to false
            anim.SetBool("noFragments", false);
            anim.SetBool("hasFragmentOne", false);
            anim.SetBool("hasFragmentTwo", false);
            anim.SetBool("hasFragmentThree", false);
            anim.SetBool("hasFragmentFour", false);


            if (keycardID == 1)
            {
                Debug.Log("Fragment 1 collected");
                anim.SetBool("hasFragmentOne", true);
            }
            if (keycardID == 2)
            {
                Debug.Log("Fragment 2 collected");
                anim.SetBool("hasFragmentTwo", true);
            }
            if (keycardID == 3)
            {
                Debug.Log("Fragment 3 collected");
                anim.SetBool("hasFragmentThree", true);
            }
            if (keycardID == 4)
            {
                Debug.Log("Fragment 4 collected");
                anim.SetBool("hasFragmentFour", true);
            }


            AudioSource.PlayClipAtPoint(audioSource, transform.position, volume);
            Destroy(gameObject);
            Destroy(barrier);
        }

    }
}
