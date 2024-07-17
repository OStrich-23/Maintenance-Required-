using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject prefab;
    public GameObject prefab2;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)){
        Instantiate(prefab, transform.position, transform.rotation);
        }
        if(Input.GetKeyDown(KeyCode.Mouse0)){
        Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
