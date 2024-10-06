using SuperPupSystems.Helper;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Audio;

public abstract class Attack : MonoBehaviour
{
    private PlayerManager m_playerManager;

    public KeyCode attackKey;
    public Transform attackPoint;
    public LayerMask enemyLayers;
    public float attackCooldown;
    public int attackDmg;
    public float circleAttackRange;
    public Vector2 squareAttackRange;
    public Animator attackAnim;
    public string animTrigger;
    [HideInInspector] public float attackNext;
    private float m_angle;

    public AudioSource attackSound;

    private void Awake()
    {
         m_playerManager = GetComponent<PlayerManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnAttackCircle()
    {
        if (Input.GetKeyDown(attackKey) && Time.time >= attackNext)
        {
            attackNext = Time.time + attackCooldown;
            attackAnim.SetTrigger(animTrigger);
            attackSound.Play();

            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, circleAttackRange, enemyLayers);

            foreach (Collider2D enemy in hitEnemies)
            {
                enemy.GetComponent<Health>().Damage(attackDmg);
                if (m_playerManager.webPower == true)
                {
                    Debug.Log("Webbed");
                    enemy.GetComponent<EnemyAI>().webbed = true;
                }
                if(m_playerManager.firePower == true)
                    enemy.GetComponent<Health>().Damage(attackDmg);
            }
        }
    }
    public void OnAttackSquare()
    {

        if (Input.GetKeyDown(attackKey) && Time.time >= attackNext)
        {
            attackNext = Time.time + attackCooldown;
            attackAnim.SetTrigger(animTrigger);
            Collider2D[] hitEnemies = Physics2D.OverlapBoxAll(attackPoint.position, squareAttackRange, m_angle, enemyLayers);
            attackSound.Play();

            foreach (Collider2D enemy in hitEnemies)
            {
                enemy.GetComponent<Health>().Damage(attackDmg);
                if (m_playerManager.webPower == true)
                {
                    Debug.Log("Webbed");
                    enemy.GetComponent<EnemyAI>().webbed = true;
                }
                    
            }
        }
    }

    
}
