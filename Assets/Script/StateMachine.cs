using System.Collections;
using System.Collections.Generic;
using Vuforia;
using UnityEngine;

public class StateMachine : MonoBehaviour {

    [SerializeField]
    private GameObject scannerScreen;

    private int trackers = 0;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        //Should be canged
        if (trackers <= 0)
        {
            scannerScreen.SetActive(true);
        }
        else {
            scannerScreen.SetActive(false);
        }
    }

    public void addTracked() {
        trackers++;
        Debug.Log("Trackers = " + trackers);
    }

    public void removeTracked() {
        trackers--;
        Debug.Log("Trackers = " + trackers);
    }





    private bool isTrackingMarker(string imageTargetName)
    {
        var imageTarget = GameObject.Find(imageTargetName);
        var trackable = imageTarget.GetComponent<TrackableBehaviour>();
        var status = trackable.CurrentStatus;
        return status == TrackableBehaviour.Status.TRACKED;
    }

}

