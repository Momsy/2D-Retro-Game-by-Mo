using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTrap : MonoBehaviour
{
[SerializeField] private float sp = 3f;// the var of the speed serialized with that we can modifie the value of the speed without coming into the code 

     private void Update()
    {
        transform.Rotate(0,0, 360 * sp * Time.deltaTime);
    }
}
