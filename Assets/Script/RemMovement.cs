using Unity.VisualScripting;
using UnityEngine;

public class RemMovement : MonoBehaviour
{
    public float speed;
    float horizontal;
    float vertical;
    bool inLight = false;
    bool inRange = false;
    bool puzzleOpen = false;

    Animator anim;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Light"))
        {
            inLight = true;
        }
        if (collision.CompareTag("Fusebox")) 
        {
            inRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Fusebox"))
        {
            inRange = false;
        }
    }

    public void MinigameOpen()
    {
        puzzleOpen = true;
    }
    public void MinigameClosed()
    {
        puzzleOpen = false;
    }


    // Update is called once per frame
    void Update()
    {
        //stop movement when inventory is open
        if (anim.GetBool("openInventory"))
        {
            return;
        }

        //stop movement when puzzle minigame is open or when in light
        if (puzzleOpen || inLight)
        {
            anim.SetBool("isWalking", false);
            return;
        }

        //movement controls linked to idle and walk animation transitions
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        if (horizontal != 0 || vertical != 0)
        {
            anim.SetBool("isWalking", true);
            
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

        anim.SetFloat("horizontal", horizontal);
        anim.SetFloat("vertical", vertical);

        Vector3 moveDirection = new Vector2(horizontal, vertical);
        transform.position += speed * Time.deltaTime * moveDirection;
    }
}
