﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This destroys the food when it touches the trigger.//

public class DestroyFood : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
