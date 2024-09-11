using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rigidBody2d;
    public float speed = 0;
    private Vector2 velocity;
    void Start()
    {
        velocity.x = Random.Range(-1f, 1f);
        velocity.y = 1;

        rigidBody2d.AddForce(velocity * speed);
    }

    
}
