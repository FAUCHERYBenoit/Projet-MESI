using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

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

    public UnityEvent onDashStart = new UnityEvent();
    public UnityEvent onDashStop = new UnityEvent();
    public UnityEvent onWalk = new UnityEvent();
    public UnityEvent onStop = new UnityEvent();


    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
   
    public void moveCharacter(Vector2 direction)
    {
        if(canMove)
        {
            onWalk.Invoke();
            rb.velocity = direction * speed;
            Vector3 newDir = new Vector3(direction.x, direction.y, 0);
            rb.velocity = newDir * speed;
        }
    }

    public void Dash(Vector3 direction)
    {
        if (canMove)
        {
            canMove= false;
            rb.AddForce(direction*dashIntensity);
            Vector3 newDir = new Vector3(direction.x, direction.y, 0);
            rb.AddForce(newDir*dashIntensity);
            StartCoroutine(DashTimer());
        }
    }

    public void RotatePlayer(Transform transform)
    {
        Vector3 direction = transform.position - this.transform.position;
        float angle = Vector2.SignedAngle(Vector2.right, direction);
        this.transform.eulerAngles = new Vector3(0, 0, angle);
    }

    IEnumerator DashTimer()
    {
        onDashStart?.Invoke();
        yield return new WaitForSeconds(dashTimer);
        onDashStop?.Invoke();  
        canMove = true;
        yield return null;
    }

    internal void Stop()
    {
        onStop?.Invoke();   
    }
}
