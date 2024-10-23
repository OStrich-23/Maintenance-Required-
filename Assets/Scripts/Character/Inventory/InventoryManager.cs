using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject inventoryUI;  // Assign your inventory UI Panel here
    private bool isInventoryOpen = false;

    void Start()
    {
        // Ensure the inventory UI is initially inactive
        inventoryUI.SetActive(false);
    }

    void Update()
    {
        // Check if the E key is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            ToggleInventory();
        }
    }

    void ToggleInventory()
    {
        // Toggle inventory state
        isInventoryOpen = !isInventoryOpen;

        // Enable or disable the inventory UI
        inventoryUI.SetActive(isInventoryOpen);

        // Lock/unlock the cursor based on the inventory state
        if (isInventoryOpen)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
