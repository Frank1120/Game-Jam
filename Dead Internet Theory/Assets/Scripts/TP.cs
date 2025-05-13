using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP : MonoBehaviour
{
    public Transform tpPoint;
    public GameObject Engie;
    private void OnTriggerEnter(Collider collide)
    {
        if (collide.tag == "Player")
        {
            Engie.transform.position = tpPoint.transform.position;
        }
    }
}
