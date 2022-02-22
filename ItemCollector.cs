using System.Collections;
using UnityEngine.UI;//help us to import package for the txt 
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private int cmp_orange = 0;// compteur of orange
    [SerializeField] private Text orangetxt;// allow me to modify the txt on unity no need to comeback on the code everytime 

    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.gameObject.CompareTag("Orange"))//orange is the tag that i use for my items
         {
            Destroy(collision.gameObject); //destroy method will help me to make disappear the item on the screen 
            cmp_orange = cmp_orange +1;// incrementation of my counter 
            orangetxt.text = "Oranges: " +cmp_orange;// eveytime that character collect on item the counter increment
         }
    }

}
