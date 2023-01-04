using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementService : MonoBehaviour
{
    [Header("Speed/Timer")]
    public float speed = 10.0f;
    public float dashTimer = 10f;
    public float dashIntensity = 1000f;

    [Header("MouvementParam")]
    public Rigidbody rb;
    public Vector2 movement;
    public bool canMove = true;
    

    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
   
    public void moveCharacter(Vector2 direction)
    {
        if(canMove)
        {
            rb.velocity = direction * speed;
        }
    }

    public void Dash(Vector3 direction)
    {
        if (canMove)
        {
            canMove= false;
            rb.AddForce(direction*dashIntensity);
            StartCoroutine(DashTimer());
        }
    }

    IEnumerator DashTimer()
    {
        yield return new WaitForSeconds(dashTimer);
        canMove = true;
        yield return null;
    }
}
