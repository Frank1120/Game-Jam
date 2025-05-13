using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeWithSkybox : MonoBehaviour
{

    public GameObject grey;
    public GameObject colored;
    public Material skybox2;
    Color blueColor = new Color(0.34509803921568627f, 0.6627450980392157f, 0.8156862745098039f, 1f);

    private void OnTriggerEnter(Collider other)
    {
        RenderSettings.skybox = skybox2;
        RenderSettings.fogColor = blueColor;
        RenderSettings.fogDensity = .008f;
        grey.SetActive(false);
        colored.SetActive(true);

    }
}
