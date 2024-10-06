using SuperPupSystems.Helper;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerManager : MonoBehaviour
{
    public float speed;
    public GameObject littleguy;
    public Animator anim;

    //public LayerMask enemyLayers;

    [HideInInspector] public Rigidbody2D rb;
    [HideInInspector] public Vector2 movement;
    [HideInInspector] public Health health;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        health = GetComponent<Health>();
        
    }
    private void Start()
    {
        health.currentHealth = 1;
    }
}
