using UnityEngine;

public class Inventory : MonoBehaviour
{
    //Variables
    public bool isInventoryActive = false;
    

    //Reference
    Animator anim;
    SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
        anim.SetBool("noFragments", true);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            //open and closes inventory by flipping bool state
            isInventoryActive = !isInventoryActive;

            //setting animator bools
            anim.SetBool("isActive", isInventoryActive);
            anim.SetBool("openInventory", isInventoryActive);

            Debug.Log("Inventory active: " + isInventoryActive);
        }
    }

    public void ShowInventory()
    {
        spriteRenderer.enabled = true;
    }

    public void HideInventory()
    {
        spriteRenderer.enabled = false;
    }

}
