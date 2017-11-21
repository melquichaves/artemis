using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextType : MonoBehaviour {

    public float letterPause;
    //public AudioClip typeSound1;
    //public AudioClip typeSound2;

    string message;
    Text textComp;

    void update() {
        if (Input.touchCount > 0)
            letterPause = 0.00001f;
    }

    // Use this for initialization
    void Start () {
        textComp = GetComponent<Text>();
        message = textComp.text;
        textComp.text = "";
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText() {
        foreach (char letter in message.ToCharArray()) {
            textComp.text += letter;
            //if (typeSound1 && typeSound2)
                //SoundManager.instance.RandomizeSfx(typeSound1, typeSound2);
            yield return 0;
            yield return new WaitForSeconds(letterPause);
        }
    }


}
