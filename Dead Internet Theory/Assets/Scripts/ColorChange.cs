using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{

    public GameObject grey;
    public GameObject colored;

    private void OnTriggerEnter(Collider other)
    {
        grey.SetActive(false);
        colored.SetActive(true);

    }
}
