using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameInteractions : MonoBehaviour {
    public GameObject escolhas;
    public GameObject personagemZoom;
    public GameObject player;
    public float rotationCamera;
    private Vector3 characterPosition;
    private Quaternion characterRotation;

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

    public void CharacterZoom() {
        characterPosition = personagemZoom.transform.position;
        player.transform.position = new Vector3(characterPosition.x, characterPosition.y + 2.5f, characterPosition.z - 4);
        Camera.main.transform.rotation = new Quaternion(Camera.main.transform.rotation.x, Camera.main.transform.rotation.y + rotationCamera, Camera.main.transform.rotation.z, Camera.main.transform.rotation.w);
    
    }
}
