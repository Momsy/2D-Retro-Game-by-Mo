using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMvt : MonoBehaviour
{
    private Rigidbody2D sd;// that will helps us to gain some precious time to avoid to re write everytime rigidbody
    private Animator ani;// that var will help us to access to the condition in this animator 
    private SpriteRenderer sprt;//help us to move our character in the other direction when he wants to go to left or right it flip the image on the x axe 
    private BoxCollider2D colli;// var use for the collider 
    private float directionX; //axe where we move 
    private float characterspeed= 8f; // var speed of character
    private float jumpower = 8f; // var jumpforce when the player press space 

    private enum MovementState {idle, moving, Jump, Fall}//this are the != state of my character that i declare in the animator tab

    [SerializeField] private LayerMask NoDoubleJump;// var to avoid that the character can jump everytime that he press space
    // serialiefield help us to get the component in unity when we will be able to change the value in unity dont need anymore to come on the code 
  
    // all this declaration helps to gain some precious time and avoid us to rewrite everytime getcomponent...
   private void Start()
    {
        Debug.Log(" Test for see if there is some error");// debug test usefull for see the error when we dev program
        sd = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>(); // for that animation 
        sprt = GetComponent<SpriteRenderer>();// help us to split the frame 
        colli = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void Update(){
        directionX = Input.GetAxisRaw("Horizontal");//normally we use GETAXIS but to me more realistic in a 2d game i choose raw so when the player dont press anymore the key left/right the character stop to move
        sd.velocity = new Vector2(directionX * characterspeed, sd.velocity.y);// we use vector2 cause we are not in 3D so we dont need Z

        if (Input.GetKey("space") && Testfriction())// that condition help us to detect when the the key space is press by the player 
        {
            sd.velocity = new Vector2(sd.velocity.x, jumpower);// that will helps us to now in which direction oour character jump
        }

        UpdateAnimationVoid();// call the method below 
      
    }

    private void UpdateAnimationVoid()
    {
        MovementState state; 

          if (directionX > 0f)// that condition will helps us to switch between the different mvt running or standing
        {
            state = MovementState.moving; // we are going to know if we move to right 
            sprt.flipX = false ;//help the sprite to go back right when we press the key right 
        }
        else if(directionX < 0f) {
            state = MovementState.moving; // we are going to know if we move to left
            sprt.flipX = true ;
        }
        else {
            state = MovementState.idle;// current state of our character when he's not moving  or any key is press
        }
        if (sd.velocity.y > .1f) {// normally we should put 0.1 but when we put this this give us some kind of imprecision 
            state = MovementState.Jump;
        }
        else if (sd.velocity.y < -.1f) {
            state = MovementState.Fall;
        }

        ani.SetInteger("state", (int)state); // cast the string value in an integer for the animator 
    }

    private bool Testfriction()// this method will return true or false if we are touching the ground or not 
    {
       return  Physics2D.BoxCast(colli.bounds.center, colli.bounds.size, 0f, Vector2.down, .1f, NoDoubleJump);// return true or false if we touch the ground or not
    }
}
