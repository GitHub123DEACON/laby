using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercode : MonoBehaviour
{
    public Rigidbody rb;
    int speed = 10;
    private Vector3 moveInput;
    private bool jumping;
    
    
    
    // Use this for initialization
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        Gun = gameObject.transform.GetChild(1).GetComponent<GunScript>();
    }
    public GunScript Gun;
    private bool grounded;

    public bool Grounded;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Gun.isFiring = true;
            Debug.Log("fire");
                }

        if (Input.GetMouseButtonUp(0))
        {
            Gun.isFiring = false;
        }
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
        if (Input.GetKeyDown(KeyCode.D))
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
        moveInput = new Vector3(Input.GetAxisRaw("Horizontal") * speed, rb.velocity.y, Input.GetAxisRaw("Vertical") * speed);
        if (Input.GetButtonDown("Jump") && grounded)
        {
            jumping = true;
        }
        moveInput = transform.TransformDirection(moveInput);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;

        }



    }

    public override bool Equals(object obj)
    {
        var playercode = obj as playercode;
        return playercode != null &&
               base.Equals(obj) &&
               grounded == playercode.grounded;
    }
}