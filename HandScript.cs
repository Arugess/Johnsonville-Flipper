 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This finds the rigidbody attached to the hand, and allows it to move left or right.//

public class HandScript : MonoBehaviour
{

    //Hand control
    private Rigidbody2D handBody;

    /*private float inputDirection;
    private Vector2 moveVector;
    private CharacterController controller;*/



	void Start ()
    {
        //Gets the controller attached to the hand
        // controller = GetComponent<CharacterController>();

        handBody = GetComponent<Rigidbody2D>();

	}

	void Update ()
    {
        //Allows the player to move the hand left and right
        /*inputDirection = Input.GetAxis("Horizontal");
        controller.Move(moveVector);
        moveVector = new Vector2(inputDirection, 0);*/
        if (Input.GetKeyDown(KeyCode.D))
        {
            handBody.velocity = new Vector2(9, 0);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            handBody.velocity = new Vector2(0, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            handBody.velocity = new Vector2(-9, 0);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            handBody.velocity = new Vector2(0, 0);
        }
    }


}
