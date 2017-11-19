using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChange : MonoBehaviour {

    public Light lightPoint;

	public void TogleLight() {
        if(lightPoint.range !=0) {
            lightPoint.range = 0;
            lightPoint.intensity = 0;
        } else {
            lightPoint.range = 23.68f;
            lightPoint.intensity = 7.9f;
        }

    }
}
