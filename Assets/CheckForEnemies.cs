using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForEnemies : MonoBehaviour
{
    public GameObject[] enemy;
    public GameObject[] door;
    public Animator anim;
    public BoxCollider2D boxCollider;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        door = GameObject.FindGameObjectsWithTag("Doors");
        if (door.Length == 0)
        {
            if (enemy.Length == 0)
            {
                anim.SetTrigger("Open");
                boxCollider.isTrigger = true;
                
            }
        }
        
    }
}
