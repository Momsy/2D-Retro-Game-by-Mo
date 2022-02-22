using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesBehaviour : MonoBehaviour
{
    public int enemyLife;
    private int currentLife;
   
    // Start is called before the first frame update
    void Start()
    {
       currentLife = enemyLife;// the current life of our enymy is the enemy life 
    
    }

    // Update is called once per frame
    void Update()// that going to destroy my character when he's currentLife is equal to 0
    {
        if (currentLife <= 0)
        {
            Destroy(transform.parent.gameObject);//kill the parent of our object so that kill the enemy
        }
    }

    public void Takecoup(int coup)// that is the damage to substract 
    {
        currentLife -= coup;
    }
        

    
}
