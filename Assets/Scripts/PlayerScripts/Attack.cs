using SuperPupSystems.Helper;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Attack : MonoBehaviour
{
    private PlayerManager m_playerManager;

    public KeyCode attackKey;
    public Transform attackPoint;
    public LayerMask enemyLayers;
    public float attackCooldown;
    public int attackDmg;
    public float attackRange;
    public Animator attackAnim;
    [HideInInspector] public float attackNext;

    // Start is called before the first frame update
    void Start()
    {
        m_playerManager = GetComponent<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    public void OnAttack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Health>().Damage(attackDmg);
        }
    }
}
