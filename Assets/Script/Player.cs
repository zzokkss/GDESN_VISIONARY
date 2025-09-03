using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float speed;
    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Open Inventory");
        }
    }

    
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 moveDirection = (Vector2.right * horizontal) + (Vector2.up * vertical);
        moveDirection *= speed * Time.deltaTime;

        rb.linearVelocity = moveDirection;

        
    }
}
