using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnWallCollision : MonoBehaviour
{   
    // Other is the other object that collided with this object
    private void OnCollisionEnter(Collision other) {

        // this gets the mesh renderer component from the inspector and changes its color value for the object
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
