using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using SuperPupSystems.Helper;

public class EnemyAI : MonoBehaviour
{

    public Transform target;
    public float speed = 200f;
    public float waypointDistance = 3f;
    Path path;
    int currentWaypoint = 0;
    public Transform enemyGFX;
    Seeker seeker;
    Rigidbody2D rb;
    bool reachedEndOfPath = false;
    public Health health;
    

    // Start is called before the first frame update
    void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        InvokeRepeating("UpdatePath", 0f, .25f);
        
    }

    void UpdatePath()
    {
        if (seeker.IsDone())
            seeker.StartPath(rb.position, target.position, OnPathComplete);
    }
    void OnPathComplete(Path p)
    {
        if(!p.error)
        {
            path = p;
            currentWaypoint = 0; 
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (path == null)
            return;
        
        if(currentWaypoint >=path.vectorPath.Count)
        {
            reachedEndOfPath = true;
            return;
        } else
        {
            reachedEndOfPath = false;
        }

        Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - rb.position).normalized;
        Vector2 force = direction * speed * Time.deltaTime;

        rb.AddForce(force);

        float distance = Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);
        if (distance < waypointDistance)
        {
            currentWaypoint++;
        }

        /* if(force.x >= 0.01f)
        {
            enemyGFX.localScale = new Vector3(-1f, 1f, 1f); 
            Debug.Log("peanits");
        } else if (force.x <= 00.01f)
        {
            enemyGFX.localScale = new Vector3(1f, 1f, 1f);
            Debug.Log("jorkin it");*/


            
        }
        void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.tag == "Player")
            {
                col.gameObject.GetComponent<Health>().Damage(1);
            }
        }
    }
