using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlateController : MonoBehaviour {


    public HideGolemEvent hideGolem;
    public GameObject[] plates;
    private int index = 0;



    // Use this for initialization
    void Start() {
        foreach (var g in plates) g.SetActive(false);
        plates[0].SetActive(true);
    }

    // Update is called once per frame
    void Update() {

    }

    public void onClick() {
        Debug.Log("On click");
        plates[index].SetActive(false);
        if (index == plates.Length - 1) {
            hideGolem.Invoke();
            return;
        }
        index++;
        plates[index].SetActive(true);
    }
}
