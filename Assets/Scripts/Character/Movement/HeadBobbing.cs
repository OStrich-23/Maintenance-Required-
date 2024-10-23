using UnityEngine;

public class HeadBobbing : MonoBehaviour
{
    public float bobbingSpeed = 0.18f;  // How fast the bobbing occurs
    public float bobbingAmount = 0.02f;  // Reduce bobbing amount for subtler effect
    public float midpoint = 2f;  // Default Y position of the camera

    private float timer = 0f;
    private float currentBobbingAmount = 0f;  // To smoothly apply bobbing
    private float smoothTransition = 4f;  // How quickly the bobbing applies/stops
    private PlayerMovement playerMovement;  // Reference to PlayerMovement

    void Start()
    {
        playerMovement = GetComponentInParent<PlayerMovement>();  // Reference PlayerMovement script
    }

    void Update()
    {
        // Get input for player movement (WASD / Arrow keys)
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Check if player is moving (slight threshold to avoid tiny movements)
        bool isMoving = Mathf.Abs(horizontal) > 0.1f || Mathf.Abs(vertical) > 0.1f;

        if (isMoving)
        {
            // Increase the timer for the bobbing effect
            timer += Time.deltaTime * bobbingSpeed;

            // Gradually increase bobbing when moving
            currentBobbingAmount = Mathf.Lerp(currentBobbingAmount, bobbingAmount, Time.deltaTime * smoothTransition);

            // Calculate the bobbing using a sine wave
            float bobbingOffset = Mathf.Sin(timer) * currentBobbingAmount;

            // Apply the bobbing to the camera's Y position
            transform.localPosition = new Vector3(transform.localPosition.x, midpoint + bobbingOffset, transform.localPosition.z);
        }
        else
        {
            // Gradually reduce bobbing when stopping
            currentBobbingAmount = Mathf.Lerp(currentBobbingAmount, 0, Time.deltaTime * smoothTransition);

            // Reset the bobbing effect to stop it smoothly
            timer = 0f;
            transform.localPosition = new Vector3(transform.localPosition.x, midpoint, transform.localPosition.z);
        }
    }
}
