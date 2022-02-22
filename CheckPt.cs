using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CheckPt : MonoBehaviour
{
    private bool lvlcomplete = false;
    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)// help to detect the interaction between the character and the checkpoint
    {
        if (collision.gameObject.name == "Character" && !lvlcomplete)
        {
            Invoke("LvlDone", 1.5f);//that method help me to gain some time when i want to change the lvl of the different game          
            lvlcomplete= true;//fixing sound bug 
        }
    }

    private void LvlDone()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);// help me to switch to another lvl by adding one 
    }
}
