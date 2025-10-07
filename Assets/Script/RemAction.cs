using UnityEngine;

public class RemAction : MonoBehaviour
{
    //Variables
    public bool isActive = false;

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
        if (Input.GetKeyDown(KeyCode.I))
        {
            bool current = anim.GetBool("openInventory");
            anim.SetBool("openInventory", !current);
            isActive = !isActive;

        }

        if (isActive == true)
        {
            inventory.SetActive(true);
        }
        else
        {
            inventory.SetActive(false);
        }

    }
}
