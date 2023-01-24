using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class CrossAir : MonoBehaviour
{
    public UnityEvent<Transform> CrossAirPositionChanged;

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        UpdatePosition();
    }

    private void UpdatePosition()
    {
        Vector3 mousePos = new Vector3(Mouse.current.position.ReadValue().x, Mouse.current.position.ReadValue().y, 10);
        Vector3 objPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = objPos;

        CrossAirPositionChanged?.Invoke(transform);
    }
}
