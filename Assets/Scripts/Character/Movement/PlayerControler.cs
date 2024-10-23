using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject gunPrefab; // Assign your gun prefab in the Inspector
    private GameObject currentGun; // Reference to the current instantiated gun
    public Transform rightHand; // Assign the RightHand GameObject in the Inspector

    void Update()
    {
        // Check if the key is pressed (you can change KeyCode to any key you prefer)
        if (Input.GetKeyDown(KeyCode.G)) // Change to your desired key
        {
            ToggleGun();
        }
    }

    void ToggleGun()
    {
        // Check if the gun is already instantiated
        if (currentGun == null)
        {
            // Instantiate the gun at the RightHand position
            currentGun = Instantiate(gunPrefab, rightHand.position, rightHand.rotation);
            currentGun.transform.SetParent(rightHand); // Make it a child of the RightHand
            currentGun.transform.localPosition = Vector3.zero; // Position it correctly in the hand
            currentGun.transform.localRotation = Quaternion.identity; // Reset rotation if needed
            Debug.Log("Gun spawned at: " + rightHand.position);
        }
        else
        {
            // Destroy the gun if it exists
            Destroy(currentGun);
            Debug.Log("Gun destroyed.");
        }
    }
}
