using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookCrosshair : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - transform.position;
        float angle = Vector2.SignedAngle(Vector2.right, direction);
        transform.eulerAngles = new Vector3(0, 0, angle);
        Debug.Log("mousePosition" + mousePosition);
        Debug.Log("direction" + direction);
        Debug.Log("angle" + angle);
        Debug.Log(" transform.eulerAngles" + transform.eulerAngles);
    }
}