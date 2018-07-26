using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercode : MonoBehaviour {
    public Rigidbody rb;
    int speed = 10;

	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = new Vector3(0, 0, 5);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = new Vector3(0, 0, -5);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector3(5, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector3(-5, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        { rb.velocity = new Vector3(0, 5, 0); }

        if (Input.GetKeyUp(KeyCode.A))
        { rb.velocity = new Vector3(0, 0, 0); }


        if (Input.GetKeyUp(KeyCode.W))
        { rb.velocity = new Vector3(0, 0, 0); }

        if (Input.GetKeyUp(KeyCode.S))
        { rb.velocity = new Vector3(0, 0, 0); }


        if (Input.GetKeyUp(KeyCode.D))
        { rb.velocity = new Vector3(0, 0, 0); }

        if (Input.GetKeyUp(KeyCode.Space))
        { rb.velocity = new Vector3(0, 0, 0); }


    }



}
