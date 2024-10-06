using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using SuperPupSystems.Helper;

public class RangedEnemy : MonoBehaviour
{

    public Transform target;
    public float maxSpeed = 200f;
    private float speed;
    private float webbedSpeed;
    public float waypointDistance = 3f;
    Path path;
    int currentWaypoint = 0;
    public Transform enemyGFX;
    Seeker seeker;
    Rigidbody2D rb;
    bool reachedEndOfPath = false;
    public Health health;
    public bool webbed = false;
    public bool onFire = false;
    public float distanceToShoot = 5f;
    public float distanceToStop = 3f;
    public GameObject bullet;
    public Transform fireballPoint;
    

    // Start is called before the first frame update
    void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();
        speed = maxSpeed;
        webbedSpeed = maxSpeed * .5f;

        InvokeRepeating("UpdatePath", 0f, .25f);
        InvokeRepeating("Shoot", 2f, 2f);
        
    }

    void UpdatePath()
    {
        if (seeker.IsDone())
            seeker.StartPath(rb.position, target.position, OnPathComplete);
    }
    void Shoot()
    {
        Instantiate(bullet, fireballPoint.position, fireballPoint.rotation);
    }
    void OnPathComplete(Path p)
    {
        if(!p.error)
        {
            path = p;
            currentWaypoint = 0; 
        }
    }
    private void Update()
    {
        if (webbed)
        {
            speed = webbedSpeed;
        }
        else
            speed = maxSpeed;
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

        if (Vector2.Distance(target.position, transform.position) >= distanceToStop)
        {
            rb.AddForce(force);
        } else
        {
            rb.AddForce(force * -1);
        }

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
                col.gameObject.GetComponent<PlayerManager>().webPower = false;
                col.gameObject.GetComponent<PlayerManager>().firePower = false;

            }   
        }
}
