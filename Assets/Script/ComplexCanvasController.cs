using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class ComplexCanvasController : MonoBehaviour {

    public GameObject[] golems;
    public GameObject[] btns;

    public void hideGolem() {
        foreach (var go in golems) go.SetActive(false);
        foreach (var go in btns) go.SetActive(true);
        Debug.Log("Golem hided");
    }

    // Use this for initialization
    void Start () {
        foreach (var go in golems) go.SetActive(false);
        foreach (var go in btns) go.SetActive(true);
        if (golems.Length != btns.Length) Debug.LogWarning("Quantity of golems and btns isn't equal");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void click(int index) {
        //Disable all other buttons
        for (int i = 0; i < btns.Length; i++) {
            if (i != index) {
                btns[i].SetActive(false);
            }
        }

        golems[index].SetActive(true);
    }
}
[System.Serializable]
public class HideGolemEvent : UnityEvent {}
