using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keycard : MonoBehaviour
{
    
    private void OnTriggerEnter(UnityEngine.Collider trigger){
        // uses this to tell if the player is the one touching the collider
        PlayerKeycards playerKeycards = trigger.GetComponent<PlayerKeycards>();
        
        // if it is the player touching the collider then the number of keycards will increase and the keycard will disappear
        if (trigger.gameObject.tag == "Player") {
            playerKeycards.KeycardCollected();
            gameObject.SetActive(false);
        }
    }
}
