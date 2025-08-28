using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; // The speed of the contoller
    public float rotSpeed; // The rotation speed of the controller

    public float hInput; // Store values for horizontal movement
    public float vInput; // Store values for vertical movement

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, hInput * rotSpeed * Time.deltaTime); // Makes the vehicle rotate side to side
        transform.Translate(Vector3.forward * vInput * speed * Time.deltaTime); // Makes the vehicle move forwards and backwards

    }
}
