using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour {

    [SerializeField]
    private GameObject scannerScreen;

    private int tracked = 0; 


    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (tracked<=0)
        {
            scannerScreen.SetActive(true);
        }
        else {
            scannerScreen.SetActive(false);
        }
    }

    public void addTracker()
    {
        tracked++;
    }

    public void removeTracker()
    {
        tracked--;
    }
}
