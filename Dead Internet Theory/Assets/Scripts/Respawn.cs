using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform respawnPoint;
    public GameObject Engie;
    private void OnTriggerEnter(Collider collide)
    {
        if (collide.tag == "Player")
        {
            Engie.transform.position = respawnPoint.transform.position;
        }
    }
}
