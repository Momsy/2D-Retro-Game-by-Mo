using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// help me to switch between the != scenes


public class LaunchMenu : MonoBehaviour
{
    public void Launching()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //allow me to go to the first lvl when the button is selected 
    }
}
