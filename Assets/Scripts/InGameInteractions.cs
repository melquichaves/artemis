using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class InGameInteractions : MonoBehaviour {
    public GameObject escolhas;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
    }

    public void ToggleCharacterMenu() {
        if(!escolhas.activeSelf) {
            escolhas.SetActive(true);
        } else {
            escolhas.SetActive(false);
        }
    }

    public void BackToScene() {
        SceneManager.LoadScene(0);
    }

}
