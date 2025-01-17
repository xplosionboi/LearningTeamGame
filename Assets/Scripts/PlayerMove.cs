using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMove : MonoBehaviour
{
    public CharacterController2D characterControl;

    public float playerSpeed;
    
    private float horizontalMove;
    private bool jump;

    private bool crouch;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * playerSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if(Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

    }

    private void FixedUpdate()
    {
        characterControl.Move(horizontalMove, crouch, jump);
        jump = false;
    }
}
