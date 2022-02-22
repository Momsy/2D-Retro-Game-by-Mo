using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//help me to reload the lvl 

public class CharacterLongevity : MonoBehaviour
{
    private Animator ani;//help me to switch to the dead animation
    private Rigidbody2D sd;// help me to disable the mvt of the character when he die 

   private void Start()
    {
        ani = GetComponent<Animator>();
        sd = GetComponent<Rigidbody2D>();

    }

    private void OnCollisionEnter2D(Collision2D collision)// detect collision between my character and the trap or the enmey 
    {
        if (collision.gameObject.CompareTag("Trap"))//assign  to the object trap 
        {
            Death();
        }
        if (collision.gameObject.CompareTag("enemy"))
        {
            Death();
            
        }
    }

    private void Death()
    {
        sd.bodyType = RigidbodyType2D.Static;// with that the character cant move when he die 
        ani.SetTrigger("die");
    }

    private void ReloadingLvl()//help me to reload the lvl eveytime that the player die 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//restart the same lvl but at the beginning 
    }

}
//for the death animation i could use a delay to give me 3 or 2 second before reloading the lvl or timesleep library
//like in the C language but the unity component help me to do that by adding an event in the animator after 
//the death animation by calling the reloadinglvl method 