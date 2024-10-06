using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class doorTrigger : MonoBehaviour
{
    public UnityEvent doorEntered;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            doorEntered.Invoke();
        }
    }
    public void deletedoor()
    {
        Destroy(this.gameObject);
    }
    public void TimeScale()
    {
        Time.timeScale = 0f;
    }
}
