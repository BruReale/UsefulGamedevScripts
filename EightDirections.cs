using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EightDirections : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2D;

   //basic 8-direction movement with RigidBody2D and velocity set

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb2D.velocity = new Vector2
                (Input.GetAxis("Horizontal") * speed * Time.deltaTime,
                Input.GetAxis("Vertical") * speed * Time.deltaTime);
    }
}
