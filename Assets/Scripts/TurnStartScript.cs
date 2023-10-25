using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class TurnStartScript : MonoBehaviour
{

    public UnityEvent startTurn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartTurn(InputValue value)
    {
        startTurn.Invoke();
    }

}
