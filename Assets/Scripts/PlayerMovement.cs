using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 5;
    public float gravity = -5;

    float velocityY = 0;

    CharacterController controller;

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        velocityY += gravity * Time.deltaTime;
        Vector3 pos = transform.position;

        Vector3 temp = Vector3.zero;
        if (Input.GetKey ("a"))
        {
            pos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey("w"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed+= speed * 1+(1/16);
        }
        transform.position = pos;

        Vector3 velocity = pos * speed;
        velocity.y = velocityY;

        if (controller.isGrounded)
        {
            velocityY = 0;
        }
	}
}
