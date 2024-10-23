using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Canvas canvas;  // Reference to the canvas for positioning
    private RectTransform rectTransform;  // To modify item's position
    private CanvasGroup canvasGroup;  // To manage UI interaction while dragging
    private Vector3 originalPosition;  // To store the item's original position

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();

        // Find the Canvas component in the parent hierarchy
        canvas = GetComponentInParent<Canvas>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalPosition = rectTransform.anchoredPosition;  // Save original position
        canvasGroup.blocksRaycasts = false;  // Make it non-interactable while dragging
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Move the item as the mouse moves
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;  // Re-enable interaction

        // You can add logic to snap the item back to its original position if needed
        // rectTransform.anchoredPosition = originalPosition;
    }
}
