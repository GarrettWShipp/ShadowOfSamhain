using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float speed;
    public float damage;
    public GameObject littleguy;
    [HideInInspector] public Rigidbody2D rb;
    [HideInInspector] public Vector2 movement;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
}
