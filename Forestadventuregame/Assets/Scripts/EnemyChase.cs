﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{

    Vector3 startPosition;
    public Vector3 paceDirection = new Vector3(0, 0, 0);
    public float paceDistance = 3.0f;
    public float moveSpeed = 3.0f;
    // Use this for initialization
    void Start()
    {
        // store each enemies unique starting position
        startPosition = transform.position;
        paceDirection.Normalize();
        paceDirection = paceDirection * moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 displacment = transform.position - startPosition;
        float distanceFromStart = displacment.magnitude;
        if (distanceFromStart >= paceDistance)
        {
            //change direction
            paceDirection = -paceDirection;
        }
        GetComponent<Rigidbody2D>().velocity = paceDirection;
    }
}
