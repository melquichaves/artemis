using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ChangeRoom : MonoBehaviour {
    public string goToLevel;

	// Use this for initialization
	void Start () {
		
	}

    public void DoorClick() {
        SceneManager.LoadScene(goToLevel);
    }
	
}
