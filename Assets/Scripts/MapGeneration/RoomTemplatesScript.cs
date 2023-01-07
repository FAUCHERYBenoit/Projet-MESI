using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplatesScript : MonoBehaviour
{
    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;
    public GameObject closedRoom;

    public List<GameObject> rooms;

    [SerializeField]
    private GameObject boss;
    [SerializeField]
    private GameObject firstRoomIndicator;
    [SerializeField]
    private float waitTime;

    private void Start()
    {
        StartCoroutine(waitForGenerated());
    }

    private IEnumerator waitForGenerated()
    {
        yield return new WaitForSeconds(waitTime);
        //G�n�re le boss dans la derni�re salle & un point bleu dans la premi�re
        Instantiate(firstRoomIndicator, rooms[0].transform.position, rooms[0].transform.rotation);
        Instantiate(boss, rooms[rooms.Count - 1].transform.position, rooms[rooms.Count - 1].transform.rotation);
    }
}
