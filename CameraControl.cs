using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private Transform character;// reference to the transform of our character 

    private void Update() {// set the postion of the camera on the character in each != frame 
        transform.position = new Vector3(character.position.x, character.position.y, transform.position.z); // i want to keep the postion z that i already add thats why z take transform and not character 
    }
}
//that will help us for the camera now on the tab of main camera i drag the character 
//on the column now when the character is going to move the camera will follow it 
// just need to add this script to main camera and add the character transform component into it 