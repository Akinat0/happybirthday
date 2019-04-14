using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beh : MonoBehaviour
{

    private StateMachine stateMachine;



    private void Awake()
    {
        stateMachine = FindObjectOfType<StateMachine>().GetComponent<StateMachine>();

        if (stateMachine != null) print("I found state machine");

    }
    private void OnEnable()
    {
        stateMachine.addTracker();
    }

    private void OnDisable()
    {
        stateMachine.removeTracker();
    }
}
