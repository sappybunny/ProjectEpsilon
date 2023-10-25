using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionTimeQueue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Dequeues Actions in time with FixedUpdate
    private void FixedUpdate()
    {
        gameObject.SendMessage("QueueAction");
    }
}
