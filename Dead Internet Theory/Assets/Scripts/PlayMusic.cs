using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public AudioSource audio;
    private void OnTriggerEnter(Collider other)
    {
        audio.GetComponent<AudioClip>();
        if (other.tag == "Player")
        {
            audio.Play();
        }
    }
}
