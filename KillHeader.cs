using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillHeader : MonoBehaviour
{

    public int coup;
    private Rigidbody2D skurt;
    public float rema;//bouncing force 
    // Start is called before the first frame update
    void Start()
    {
      skurt = transform.parent.GetComponent<Rigidbody2D>(); //ref to the rigibody to get the parent rigibody
    }

    private void OnTriggerEnter2D(Collider2D bang)//when we collide with another object
    {
        if (bang.gameObject.tag == "headboom")// when this box collider collide with the boxcollider who has the tag headboom that will destroy him 
        {
            bang.gameObject.GetComponent<EnemiesBehaviour>().Takecoup(coup);//reference to the enemy script
            skurt.AddForce(transform.up * rema, ForceMode2D.Impulse);// get the animation of jumping after hitting the enemy how far the character is going to go when he jump on them 
        }
    }
}
