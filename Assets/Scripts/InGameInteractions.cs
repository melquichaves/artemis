using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using UnityEngine.PostProcessing;

public class InGameInteractions : MonoBehaviour {
    public GameObject escolhas;
    public GameObject personagemZoom;
    public GameObject player;
    public PostProcessingProfile post;
    public GvrControllerInput cameravr;
    private Vector3 characterPosition;
    private Quaternion characterRotation;
    private bool pointCharacter = false;
    

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if(pointCharacter)
        Camera.main.transform.LookAt(personagemZoom.transform);
    }

    public void ToggleCharacterMenu() {
        if(!escolhas.activeSelf) {
            escolhas.SetActive(true);
        } else {
            escolhas.SetActive(false);
        }
    }

    public void ToggleZoom() {
        if (!pointCharacter) {
            CharacterZoom();
        } else {
            CharacterZoomAlt();
        }
    }


    public void CharacterZoom() {
        post.depthOfField.enabled = true;
        player.transform.position = new Vector3(-2, 0, 2);
        pointCharacter = true;
        cameravr.enabled = false;

    }


    public void CharacterZoomAlt() {
        post.depthOfField.enabled = false;
        Debug.Log("tá caindo aqui");
        player.transform.position = new Vector3(0, 1, 0);
        pointCharacter = false;
    }
}
