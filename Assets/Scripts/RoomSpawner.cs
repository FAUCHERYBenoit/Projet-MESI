using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public Direction openingDirection;
    // TOP --> need BOTTOM door
    // BOTTOM --> need TOP door
    // LEFT --> need RIGHT door
    // RIGHT --> need LEFT door

    private RoomTemplatesScript templates;
    private int rdm;
    private bool hasSpawned = false;

    private void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplatesScript>();
        Invoke("Spawn", 0.1f);
    }

    private void Spawn()
    {
        if (!hasSpawned)
        {
            switch (openingDirection)
            {
                case Direction.TOP:
                    //Need to spawn room with BOTTOM door
                    rdm = Random.Range(0, templates.bottomRooms.Length);
                    Instantiate(templates.bottomRooms[rdm], transform.position, templates.bottomRooms[rdm].transform.rotation);
                    break;
                case Direction.RIGHT:
                    //Need to spawn room with LEFT door
                    rdm = Random.Range(0, templates.leftRooms.Length);
                    Instantiate(templates.leftRooms[rdm], transform.position, templates.leftRooms[rdm].transform.rotation);
                    break;
                case Direction.BOTTOM:
                    //Need to spawn room with TOP door
                    rdm = Random.Range(0, templates.topRooms.Length);
                    Instantiate(templates.topRooms[rdm], transform.position, templates.topRooms[rdm].transform.rotation);
                    break;
                case Direction.LEFT:
                    //Need to spawn room with RIGHT door
                    rdm = Random.Range(0, templates.rightRooms.Length);
                    Instantiate(templates.rightRooms[rdm], transform.position, templates.rightRooms[rdm].transform.rotation);
                    break;
            }
            hasSpawned = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpawnPoint"))
        {
            if(!other.GetComponent<RoomSpawner>().hasSpawned && !hasSpawned)
            {
                Instantiate(templates.closedRoom, transform.position, templates.closedRoom.transform.rotation);
                Destroy(gameObject);
            }
            hasSpawned = true;
            //TODO faire une chambre secrete
            // Régler les portes qui donnent sur un mur
        }
    }
}
public enum Direction
{
    TOP, RIGHT, BOTTOM, LEFT
}
