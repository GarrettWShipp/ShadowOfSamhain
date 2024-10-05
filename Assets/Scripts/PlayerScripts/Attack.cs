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
        if (m_playerManager.movement == new Vector2(1f, 0f))
        {
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (m_playerManager.movement == new Vector2(0f, 1f))
        {
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 90);
        }
        if (m_playerManager.movement == new Vector2(-1f, 0f))
        {
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 180);
        }
        if (m_playerManager.movement == new Vector2(0f, -1f))
        {;
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 270);
        }

        if (m_playerManager.movement == new Vector2(1f, 1f))
        {
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 45);
        }
        if (m_playerManager.movement == new Vector2(-1f, -1f))
        {
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 225);
        }
        if (m_playerManager.movement == new Vector2(-1f, 1f))
        {
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 135);
        }
        if (m_playerManager.movement == new Vector2(1f, -1f))
        {
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 315);
        }

    }
    public void OnAttackCircle()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, circleAttackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Health>().Damage(attackDmg);
        }
    }
    public void OnAttackSquare()
    {

        Collider2D[] hitEnemies = Physics2D.OverlapBoxAll(attackPoint.position, squareAttackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Health>().Damage(attackDmg);
        }
    }
}
