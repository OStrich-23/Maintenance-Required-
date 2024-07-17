using UnityEngine;

public class PlaySoundAndDestroyObject : MonoBehaviour
{
    public KeyCode keyToDestroyObject = KeyCode.Space; // Define the key that will trigger the object destruction
    public AudioClip destroySound; // Audio clip to play when the object is destroyed

    private AudioSource audioSource; // Reference to the AudioSource component

    private void Start()
    {
        // Get a reference to the AudioSource component attached to this game object
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(keyToDestroyObject))
        {
            // Play the sound effect
            if (destroySound != null && audioSource != null)
            {
                GetComponent<AudioSource>().PlayOneShot(destroySound);
            }

            // Destroy the game object
            Destroy(gameObject);
        }
    }
}