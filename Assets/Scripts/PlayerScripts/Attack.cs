using SuperPupSystems.Helper;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private PlayerManager m_playerManager;

    public Transform attackPoint;
    public LayerMask enemyLayers;

    public float attackOneCooldown;
    private float attackOneNext;
    public int attackOneDmg;
    public float attackOneRange;

    public float attackTwoCooldown;
    private float attackTwoNext;
    public int attackTwoDmg;
    public float attackTwoRange;

    public float attackThreeCooldown;
    private float attackThreeNext;
    public int attackThreeDmg;
    public float attackThreeRange;

    public float attackFourCooldown;
    private float attackFourNext;
    public int attackFourDmg;
    public float attackFourRange;
    // Start is called before the first frame update
    void Start()
    {
        m_playerManager = GetComponent<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(m_playerManager.movement == new Vector2 (1f,0f))
        {
            m_playerManager.littleguy.transform.localPosition = new Vector2(1f, 0f);
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (m_playerManager.movement == new Vector2(0f, 1f))
        {
            m_playerManager.littleguy.transform.localPosition = new Vector2(0f, 1f);
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 90);
        }
        if (m_playerManager.movement == new Vector2(-1f, 0f))
        {
            m_playerManager.littleguy.transform.localPosition = new Vector2(-1f, 0f);
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 180);
        }
        if (m_playerManager.movement == new Vector2(0f, -1f))
        {
            m_playerManager.littleguy.transform.localPosition = new Vector2(0f, -1.5f);
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 270);
        }

        if (m_playerManager.movement == new Vector2(1f, 1f))
        {
            m_playerManager.littleguy.transform.localPosition = new Vector2(1f, 1f);
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 45);
        }
        if (m_playerManager.movement == new Vector2(-1f, -1f))
        {
            m_playerManager.littleguy.transform.localPosition = new Vector2(-1f, -1f);
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 225);
        }
        if (m_playerManager.movement == new Vector2(-1f, 1f))
        {
            m_playerManager.littleguy.transform.localPosition = new Vector2(-1f, 1f);
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 135);
        }
        if (m_playerManager.movement == new Vector2(1f, -1f))
        {
            m_playerManager.littleguy.transform.localPosition = new Vector2(1f, -1f);
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 315);
        }

        if (Input.GetKeyDown(KeyCode.J) && Time.time >= attackOneNext)
        {
            attackOneNext = Time.time + attackOneCooldown;
            AttackOne();
        }
    }

    void AttackOne()
    {
        //Animator.SetTrigger("AttackOne");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackOneRange, enemyLayers);
        
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Health>().Damage(attackOneDmg);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackOneRange);
    }
}
