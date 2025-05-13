using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    [SerializeField] private Animator door;
    [SerializeField] private GameObject doorObject;
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Player")
        {
            door.Play("Base Layer.DoorAnimation");
            
            door.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
    

