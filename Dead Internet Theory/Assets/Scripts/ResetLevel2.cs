using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel2 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("Level 2");
        }
    }
}
