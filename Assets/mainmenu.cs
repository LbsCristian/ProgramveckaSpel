using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{

    public void PlayGame()
    
    {
        SceneManager.LoadSceneAsync("Actual leveldesigntestBACKUP");
    }


     public void QuitGame()
    {

        Application.Quit();
    }
}
