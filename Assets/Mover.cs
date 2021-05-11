using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{   
    // Serialize fields come up in Unity inspector in the right
    [SerializeField] float xSpeed = 10f;
    [SerializeField] float zSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime makes the movement FPS independent
        float xAxis = Input.GetAxis("Horizontal") * Time.deltaTime * xSpeed;
        float zAxis = Input.GetAxis("Vertical")* Time.deltaTime * zSpeed;
        transform.Translate(xAxis,0,zAxis);
    }
}
