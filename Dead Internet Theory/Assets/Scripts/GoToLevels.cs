using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToLevels : MonoBehaviour
{
    public void Return()
    {
        SceneManager.LoadScene("LevelsScene");
    }
}
