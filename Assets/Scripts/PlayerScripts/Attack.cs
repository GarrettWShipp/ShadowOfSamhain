using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private PlayerManager m_playerManager;
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
        }
        if (m_playerManager.movement == new Vector2(0f, 1f))
        {
            m_playerManager.littleguy.transform.localPosition = new Vector2(0f, 1f);
        }
        if (m_playerManager.movement == new Vector2(-1f, 0f))
        {
            m_playerManager.littleguy.transform.localPosition = new Vector2(-1f, 0f);
        }
        if (m_playerManager.movement == new Vector2(0f, -1f))
        {
            m_playerManager.littleguy.transform.localPosition = new Vector2(0f, -1.5f);
        }

        if (m_playerManager.movement == new Vector2(1f, 1f))
        {
            m_playerManager.littleguy.transform.localPosition = new Vector2(1f, 1f);
        }
        if (m_playerManager.movement == new Vector2(-1f, -1f))
        {
            m_playerManager.littleguy.transform.localPosition = new Vector2(-1f, -1f);
        }
        if (m_playerManager.movement == new Vector2(-1f, 1f))
        {
            m_playerManager.littleguy.transform.localPosition = new Vector2(-1f, 1f);
        }
        if (m_playerManager.movement == new Vector2(1f, -1f))
        {
            m_playerManager.littleguy.transform.localPosition = new Vector2(1f, -1f);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            AttackOne();
        }
    }

    void AttackOne()
    {

    }
}
