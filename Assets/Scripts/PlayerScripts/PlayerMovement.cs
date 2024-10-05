using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerManager m_playerManager;

    private void Start()
    {
        m_playerManager = GetComponent<PlayerManager>();
    }
    // Update is called once per frame
    void Update()
    {
        m_playerManager.movement.x = Input.GetAxisRaw("Horizontal");
        m_playerManager.movement.y = Input.GetAxisRaw("Vertical");

        if (m_playerManager.movement == new Vector2(1f, 0f))
        {
            m_playerManager.littleguy.GetComponent<SpriteRenderer>().flipY = false;
            m_playerManager.littleguy.transform.localPosition = new Vector2(1f, 0f);
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (m_playerManager.movement == new Vector2(0f, 1f))
        {
            m_playerManager.littleguy.GetComponent<SpriteRenderer>().flipY = false;
            m_playerManager.littleguy.transform.localPosition = new Vector2(0f, 1f);
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 90);
        }
        if (m_playerManager.movement == new Vector2(-1f, 0f))
        {
            m_playerManager.littleguy.GetComponent<SpriteRenderer>().flipY = true;
            m_playerManager.littleguy.transform.localPosition = new Vector2(-1f, 0f);
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 180);
        }
        if (m_playerManager.movement == new Vector2(0f, -1f))
        {
            m_playerManager.littleguy.GetComponent<SpriteRenderer>().flipY = false;
            m_playerManager.littleguy.transform.localPosition = new Vector2(0f, -1.5f);
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 270);
        }

        if (m_playerManager.movement == new Vector2(1f, 1f))
        {
            m_playerManager.littleguy.GetComponent<SpriteRenderer>().flipY = false;
            m_playerManager.littleguy.transform.localPosition = new Vector2(1f, 1f);
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 45);
        }
        if (m_playerManager.movement == new Vector2(-1f, -1f))
        {
            m_playerManager.littleguy.GetComponent<SpriteRenderer>().flipY = true;
            m_playerManager.littleguy.transform.localPosition = new Vector2(-1f, -1f);
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 225);
        }
        if (m_playerManager.movement == new Vector2(-1f, 1f))
        {
            m_playerManager.littleguy.GetComponent<SpriteRenderer>().flipY = true;
            m_playerManager.littleguy.transform.localPosition = new Vector2(-1f, 1f);
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 135);
        }
        if (m_playerManager.movement == new Vector2(1f, -1f))
        {
            m_playerManager.littleguy.GetComponent<SpriteRenderer>().flipY = false;
            m_playerManager.littleguy.transform.localPosition = new Vector2(1f, -1f);
            m_playerManager.littleguy.transform.localRotation = Quaternion.Euler(0, 0, 315);
        }

    }

    private void FixedUpdate()
    {
        m_playerManager.rb.MovePosition(m_playerManager.rb.position + m_playerManager.movement * m_playerManager.speed * Time.fixedDeltaTime);
    }
}
