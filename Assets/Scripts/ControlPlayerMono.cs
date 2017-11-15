using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class ControlPlayerMono : MonoBehaviour {

    private Vector3 firstpoint; //change type on Vector3
    private Vector3 secondpoint;
    private float xAngle = 0; //angle for axes x for rotation
    private float yAngle = 0;
    private float xAngTemp = 0; //temp variable for angle
    private float yAngTemp = 0;


    // Use this for initialization
    void Start() {
        xAngle = 0;
        yAngle = 0;
        this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0);
    }

    // Update is called once per frame
    void Update() {
        if (VRSettings.loadedDeviceName == "") {
            if (Input.gyro.enabled != true) Input.gyro.enabled = true;
            this.transform.Rotate(-Input.gyro.rotationRateUnbiased.x, -Input.gyro.rotationRateUnbiased.y, 0);
            //Check count touches
            if (Input.touchCount > 0) {
                //Touch began, save position
                if (Input.GetTouch(0).phase == TouchPhase.Began) {
                    firstpoint = Input.GetTouch(0).position;
                    xAngTemp = xAngle;
                    yAngTemp = yAngle;
                }
                //Move finger by screen
                if (Input.GetTouch(0).phase == TouchPhase.Moved) {
                    secondpoint = Input.GetTouch(0).position;
                    //Mainly, about rotate camera. For example, for Screen.width rotate on 180 degree
                    xAngle = xAngTemp + (secondpoint.x - firstpoint.x) * 180 / Screen.width;
                    yAngle = yAngTemp - (secondpoint.y - firstpoint.y) * 90 / Screen.height;
                    //Rotate camera
                    this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0);
                }
            }



        } else if (VRSettings.loadedDeviceName == "cardboard") {
            if (Input.gyro.enabled != false) Input.gyro.enabled = false;
        }
    }
}
