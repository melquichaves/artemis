using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using UnityEngine.EventSystems;

public class ChangeViewMode : MonoBehaviour {

	// Use this for initialization
	void Start () {
    
    }

    /*void Update() {
        // Check if there is a touch
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
            // Check if finger is over a UI element 
            if (EventSystem.current.IsPointerOverGameObject()) {
                ToggleVR();
                //so when the user touched the UI(buttons) call your UI methods 
                Debug.Log("foi");
            }
        }
    }*/


    //Ligar VR
    IEnumerator SwitchToVR() {
        VRSettings.LoadDeviceByName("cardboard");

        // Esperar por um frame
        yield return null;

        // Agora é possível atualizar o modo VR
        VRSettings.enabled = true;
        Camera.main.fieldOfView = 55.1f;
    }

    //Desligar VR
    IEnumerator SwitchOutOfVr() {
        VRSettings.LoadDeviceByName(""); // Empty string loads the "None" device.
        

        // Wait one frame!
        yield return null;
        
        // Resetar cameras
        Camera.main.ResetAspect();
        Camera.main.fieldOfView = 80.0f;
    }


    // Trocar entre estados
    public void ToggleVR() {

        if (VRSettings.loadedDeviceName == "cardboard") {
            StartCoroutine(SwitchOutOfVr());
        } else {
            StartCoroutine(SwitchToVR());
        }
    }

}
