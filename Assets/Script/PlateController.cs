using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlateController : MonoBehaviour {


    public HideGolemEvent hideGolem;
    public GameObject[] plates;
    private int index = 0;



    // Use this for initialization
    public void OnEnable() {
        Debug.Log("OnEnable");
        foreach (var g in plates) g.SetActive(false);
        plates[0].SetActive(true);
    }

    public void OnDisable()
    {
        Debug.Log("OnDisable");
        index = 0;
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
