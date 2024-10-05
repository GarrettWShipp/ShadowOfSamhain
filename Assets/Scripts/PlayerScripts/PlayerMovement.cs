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
    }

    private void FixedUpdate()
    {
        m_playerManager.rb.MovePosition(m_playerManager.rb.position + m_playerManager.movement * m_playerManager.speed * Time.fixedDeltaTime);
    }
}
