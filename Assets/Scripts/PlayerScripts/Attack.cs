using SuperPupSystems.Helper;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

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

    // Start is called before the first frame update
    void Start()
    {
        m_playerManager = GetComponent<PlayerManager>();
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

            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, circleAttackRange, enemyLayers);

            foreach (Collider2D enemy in hitEnemies)
            {
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

            foreach (Collider2D enemy in hitEnemies)
            {
                enemy.GetComponent<Health>().Damage(attackDmg);
            }
        }
    }
}
