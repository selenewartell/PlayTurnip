﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnipMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public Sprite Parker;

    float horizontalMove = 0f;

    public float runSpeed = 40f;

    bool jump = false;


    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        // Move, crouch, jump
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}