using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided with " + collision.gameObject.name);
        if(collision.gameObject.tag == "Floor")
        {

            GetComponentInParent<poruszanie>().isGrounded = true;
        }
    }
}
