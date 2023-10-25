using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TurnTiming : MonoBehaviour
{
    public UnityEvent endTurn;
    public UnityEvent<float> displayTurnTime;

    [SerializeField]
    private float lengthOfTurns = 10;

    private float timeValue = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Enables the script when the turn is started
    public void startTurn()
    {
        enabled = true;
        timeValue = 0;
    }

    // Update is called once per frame
    // Updates current timeValue for the turn.
    void Update()
    {
        timeValue += Time.deltaTime;
    }

    // Invokes the event for updating the turn's time display in FixedUpdate.
    private void FixedUpdate()
    {
        displayTurnTime.Invoke(timeValue);

        if (timeValue >= lengthOfTurns)
        {
            // Invokes the end turn event and disables the script - resetting the time value
            endTurn.Invoke();
            enabled = false;
            timeValue = 0;
        }
    }
}
