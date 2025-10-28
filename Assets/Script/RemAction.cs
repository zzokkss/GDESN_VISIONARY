using UnityEngine;

public class RemAction : MonoBehaviour
{
   
    //Reference
    Animator anim;
    [SerializeField] GameObject inventory;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //open inventory
        if (Input.GetKeyDown(KeyCode.I))
        {
            bool current = anim.GetBool("openInventory");
            anim.SetBool("openInventory", !current);
        }

    }
}
