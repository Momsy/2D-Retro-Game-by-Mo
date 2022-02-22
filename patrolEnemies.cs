using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrolEnemies : MonoBehaviour
{

    public float mvtSpeed;
    public float rayLength;// that the length of the of the enemy
    private bool mvtLeft;// tell us if we moving left or not 
    public Transform contactChecker;// place our waypt
    // Start is called before the first frame update
    void Start()
    {
        mvtLeft = true;//when the game is launch the enemies start to move on the left
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * mvtSpeed * Time.deltaTime);//help to move the != enemies on the lef
    }

    private void FixedUpdate()
    {
        RaycastHit2D contactCheck = Physics2D.Raycast(contactChecker.position, Vector2.left, rayLength);

        if (contactCheck == true)
        {
            if (mvtLeft == true)// if i touch something i must turn on the other direction
            {
                transform.eulerAngles = new Vector2(0, -180);
                mvtLeft = false;
            }
            else
            {
                transform.eulerAngles = new Vector2(0,0);
                mvtLeft = true ;
            }
        }
    }
}
