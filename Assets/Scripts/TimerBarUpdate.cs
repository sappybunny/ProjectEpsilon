using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TimerBarUpdate : MonoBehaviour
{

    [SerializeField]
    private GameObject timerBar;



    public void displayTurnTime(float timerValue)
    {
        timerBar.GetComponent<RectTransform>().localScale = new Vector3(10f - timerValue, 1f, 1f);
    }
    public void startTurn()
    {
        timerBar.GetComponent<RectTransform>().localScale = new Vector3(10f, 1f, 1f);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
