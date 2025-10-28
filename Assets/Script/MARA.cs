using System.Collections;
using UnityEngine;
public class MARA : MonoBehaviour
{

    public float speed;
    bool inEndZone = false;

    float moveX;
    float moveY;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EndZone"))
        {
            inEndZone = true;
        }
    }

   
    // Update is called once per frame
    void Update()
    {

        if (inEndZone)
        {
            return;
        }

        moveX = 0f;
        moveY = 0f;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveY = 0.3f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveY = -0.3f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveX = -0.3f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
           moveX = 0.3f; 
        }

        Vector3 moveDirection = new Vector2(moveX, moveY);
        transform.position += speed * Time.deltaTime * moveDirection;
    }


        
}
