using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GoBackDialog : MonoBehaviour {
    public Button btn;
    public string nomeLevel;


	// Use this for initialization
	void Start () {
        btn.onClick.AddListener(TouchBtn);
    }


    public void TouchBtn() {
        SceneManager.LoadScene(nomeLevel);
    }
	
	// Update is called once per frame
	void Update () {
       /* if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
            // Check if finger is over a UI element 
            if (EventSystem.current.IsPointerOverGameObject()) {   
                Debug.Log("teste");
            }
        }*/
    }
}
