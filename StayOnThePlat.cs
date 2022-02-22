using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayOnThePlat : MonoBehaviour
{


  private void OnTriggerEnter2D(Collider2D collision)// that method help me to distinguish the 2 box collider 1 collider the other one collision
  {
        if (collision.gameObject.name =="Character")// compare the character and the plat 
      {
          collision.gameObject.transform.SetParent(transform);// that will set the character as a child of the mvt platform n we will no need to move the arrow anymore to stay on it 
      }
  }

  private void OnTriggerExit2D(Collider2D collision)
  {
         if (collision.gameObject.name =="Character")
      {
          collision.gameObject.transform.SetParent(null);// null mean no value  remove the parent
      }
  }
}
