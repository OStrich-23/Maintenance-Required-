using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeycards : MonoBehaviour
{
    // creates an integar value for keycards collected that can be
    // accessed by other scripts but only set from this one
    public int NumberOfKeycards { get; private set; }

    // creates a function that is accessible from other scripts that will increase the
    // keycards number variable
    public void KeycardCollected() {
        NumberOfKeycards++;
    }
}
