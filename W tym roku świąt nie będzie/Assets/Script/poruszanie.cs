using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poruszanie : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHight;
    public bool isGrounded;


    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHight);
            isGrounded = false;
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
    }
}
