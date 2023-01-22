using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Crossahair : MonoBehaviour
{
    public float dis = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = new Vector3(Mouse.current.position.ReadValue().x, Mouse.current.position.ReadValue().y, dis);
        Vector3 objPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = objPos;
    }
}
