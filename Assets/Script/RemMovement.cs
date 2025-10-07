using UnityEngine;

public class RemMovement : MonoBehaviour
{
    public float speed;
    float horizontal;
    float vertical;

    Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
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
