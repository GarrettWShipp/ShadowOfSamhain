using SuperPupSystems.Helper;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerManager : MonoBehaviour
{
    
    public float maxSpeed;
    [HideInInspector] public float speed;
    public GameObject littleguy;
    public Animator anim;

    public bool webPower;

    public bool firePower;

    [HideInInspector] public Rigidbody2D rb;
    [HideInInspector] public Vector2 movement;
    [HideInInspector] public Health health;

    private SpriteRenderer m_sprite;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        health = GetComponent<Health>();
        m_sprite = GetComponent<SpriteRenderer>();
        
    }
    private void Start()
    {
        health.currentHealth = 1;
    }

    private void Update()
    {
        if (firePower == true)
        {
            m_sprite.color = new Color(200, 0, 166);
        }

        if (webPower)
        {
            m_sprite.color = new Color(0, 255, 255);
        }
        if(webPower ==  false && firePower == false) 
        {
            m_sprite.color = new Color(255, 255, 255);
        }
    }


    public void StopOnDeath()
    {
        gameObject.GetComponent<PlayerManager>().enabled = false;
        gameObject.GetComponent<PlayerMovement>().enabled = false;
    }
}
