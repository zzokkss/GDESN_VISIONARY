using UnityEngine;

public class Inventory : MonoBehaviour
{
    //Variables
    public bool noFragments = true;
    public bool hasFragmentOne = false;
    public bool hasFragmentTwo = false;
    public bool hasFragmentThree = false;
    public bool hasFragmentFour = false;
    public bool isInventoryActive = false;

    //Reference
    Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Animation and Script Bools
        anim.SetBool("noFragments", noFragments);
        anim.SetBool("hasFragmentOne", hasFragmentOne);
        anim.SetBool("hasFragmentTwo", hasFragmentTwo);
        anim.SetBool("hasFragmentThree", hasFragmentThree);
        anim.SetBool("hasFragmentFour", hasFragmentFour);

        if (Input.GetKeyDown(KeyCode.I))
        {
            // Flip the state
            isInventoryActive = !isInventoryActive;

            // Set Animator bools
            anim.SetBool("isActive", isInventoryActive);
            anim.SetBool("openInventory", isInventoryActive);

            Debug.Log("Inventory active: " + isInventoryActive);

        }


    }
}
