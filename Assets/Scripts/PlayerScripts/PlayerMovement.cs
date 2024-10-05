using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerManager m_playerManager;
    private Vector2 m_movement;

    private void Start()
    {
        m_playerManager = GetComponent<PlayerManager>();
    }
    // Update is called once per frame
    void Update()
    {
        m_movement.x = Input.GetAxisRaw("Horizontal");
        m_movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        m_playerManager.rb.MovePosition(m_playerManager.rb.position + m_movement * m_playerManager.speed * Time.fixedDeltaTime);
    }
}
