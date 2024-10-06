using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public enum Direction {Bottom, Top, Left, Right, None0};
    public Direction openDir;
    private int rand;
    private bool spawned = false;
    private bool occupied;
    private GameObject[] roomList = new GameObject[0];
    private RoomTemplates templates;
    void Start(){
        templates = GameObject.FindGameObjectWithTag("Templates").GetComponent<RoomTemplates>();
        Invoke("Spawn", 1);
    }
    void Spawn()
    {
        for(int i = 0; i < roomList.Length; i++){
            if (gameObject.transform.position == roomList[i].transform.position){
                occupied = true;
            }
        }
        roomList = GameObject.FindGameObjectsWithTag("Rooms");
        if (spawned == false){
            if(openDir == Direction.Bottom && occupied != true){
                rand = Random.Range(0, templates.bottomRooms.Length);
                Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
            } else if(openDir == Direction.Top && occupied != true){
                rand = Random.Range(0, templates.topRooms.Length);
                Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);
            } else if(openDir == Direction.Left && occupied != true){
                rand = Random.Range(0, templates.leftRooms.Length);
                Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);
            } else if(openDir == Direction.Right && occupied != true){
                rand = Random.Range(0, templates.rightRooms.Length);
                Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
            }
            spawned = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Spawn Point")){
            if(other.GetComponent<RoomSpawner>().spawned == false && spawned == false){
                Instantiate(templates.closedRoom, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            spawned = true;
        }
    }
}
