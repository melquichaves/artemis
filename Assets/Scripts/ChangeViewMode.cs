using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class ChangeViewMode : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

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
