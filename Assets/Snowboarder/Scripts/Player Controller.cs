using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float tiltAmount = 10f;
    [SerializeField] float baseSpeed = 20f;
    [SerializeField] float boostSpeed = 30f;

    bool canMove = true;
    
    Rigidbody2D rb2D;

    SurfaceEffector2D surfaceEffector2D;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }
    }

    public void DisableControls()
    {
        canMove = false;
    }

    void RespondToBoost()
    {
        // if we push up, speed up
        // otherwise stay normal speed
        // acces surface effector2d

        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2D.AddTorque(tiltAmount);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2D.AddTorque(-tiltAmount);
        }
    }
}
