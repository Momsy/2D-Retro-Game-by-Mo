using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WpTracking : MonoBehaviour
{
    [SerializeField] private GameObject[] wp;//create an array to add many waypoint if i want to 
    [SerializeField] private float sp= 2f;// speed of our paltform in the game 
    private int currentIndexWp = 0;


    private void Update()//method postion of my platform each frame 
    {
        if (Vector2.Distance(wp[currentIndexWp].transform.position, transform.position) < .1f)// check the distance between 2 vector 
        {
            currentIndexWp = currentIndexWp + 1;// for the incrementation like the i index in a loop
            if (currentIndexWp >= wp.Length)//help us to get back to the first index when we reach the last one 
            {
                currentIndexWp = 0; 
            }
        }

        transform.position =  Vector2.MoveTowards(transform.position, wp[currentIndexWp].transform.position, Time.deltaTime * sp );
        //how many game unit we want to move our platforme when we want to move our platform Time.deltaTime* Speed
    }
}

//this code will help us for our platform if the platform touch the limit she will come back
// that is going to give movement to the platform