using UnityEngine;
using UnityEngine.EventSystems;

public class ItemClickHandler : MonoBehaviour, IPointerClickHandler
{
    public GameObject itemPrefab; // Assign the item prefab in the Inspector

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            ShowItem();
        }
    }

    private void ShowItem()
    {
        // Instantiate the item prefab at a certain position
        Vector3 spawnPosition = new Vector3(0, 1, 0); // Adjust the position as needed
        Instantiate(itemPrefab, spawnPosition, Quaternion.identity);
        Debug.Log("Item instantiated: " + gameObject.name);
    }
}
