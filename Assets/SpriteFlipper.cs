using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class SpriteFlipper : MonoBehaviour
{
    // Start is called before the first frame update
    public AIPath aiPath;

    // Update is called once per frame
    void Update()
    {
        if(aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f); 
            Debug.Log("peanits");
        } else if (aiPath.desiredVelocity.x <= 00.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            Debug.Log("jorkin it");
        }
    }
}
