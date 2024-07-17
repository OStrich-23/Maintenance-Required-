using UnityEngine;
using UnityEngine.UI;

public class DisplayTextOnTrigger : MonoBehaviour
{
    public PlayerKeycards playerKeycards;
    public GameObject uiObject;
    public GameObject objectiveUI;
    public GameObject escapeDoor;
   
    private void Start()
    {
        //set the ui element to invisible when the game starts so the player doesn't see it
       uiObject.SetActive(false);
       objectiveUI.SetActive(false);
    }

    private void OnTriggerEnter(UnityEngine.Collider trigger)
    {
        //make the ui element visible if the player interacts with the trigger
        if (trigger.gameObject.tag == "Player"){
            uiObject.SetActive(true);
            objectiveUI.SetActive(true);
        }
        if (playerKeycards.NumberOfKeycards == 3){
                escapeDoor.SetActive(false);
                uiObject.SetActive(false);
                objectiveUI.SetActive(false);
            }
    }

}
