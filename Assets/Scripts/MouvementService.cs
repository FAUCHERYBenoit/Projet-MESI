using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementService : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody rb;
    public Vector2 movement;

    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
    void FixedUpdate()
    {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction)
    {
        rb.velocity = direction * speed;
    }
}
