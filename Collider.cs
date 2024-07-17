
using UnityEngine;

public class Collider : MonoBehaviour
{
    private void OnCollisionEnter (Collision collision){
       Debug.Log ("keycard collected!"); 
       Destroy (collision.gameObject);
    }
}
