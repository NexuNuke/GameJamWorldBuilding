﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Vector3 initialPosition;
    float direction;
    public float maxDist;
    public float minDist;
    public float movingSpeed;
    // Use this for initialization
    void Start()
    {
        initialPosition = transform.position;
        direction = -1;
        //maxDist += transform.position.x;
        //minDist -= transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        switch (direction)
        {
            case -1:
                // Moving Left
                if (transform.position.x > minDist)
                {
                    GetComponent<Rigidbody>().velocity = new Vector2(-movingSpeed, GetComponent<Rigidbody>().velocity.y);
                }
                else
                {
                    direction = 1;
                }
                break;
            case 1:
                //Moving Right
                if (transform.position.x < maxDist)
                {
                    GetComponent<Rigidbody>().velocity = new Vector2(movingSpeed, GetComponent<Rigidbody>().velocity.y);
                }
                else
                {
                    direction = -1;
                }
                break;
        }
    }

}


