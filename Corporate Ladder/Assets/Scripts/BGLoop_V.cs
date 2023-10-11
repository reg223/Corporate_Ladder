
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class backgroundLoopSimple : MonoBehaviour {
    public Transform centerBG;
    public float offset = 720f;       //this value is the width of the image
    // void Start() {
    //     centerBG = GameObject.Find("BG").GetComponent<Transform>();
    // }
    
    void Update(){
        if (transform.position.y >= centerBG.position.y + offset){
            centerBG.position = new Vector2(centerBG.position.x, transform.position.y + offset);
        } else if (transform.position.y <= centerBG.position.y - offset) {
            centerBG.position = new Vector2(transform.position.x, transform.position.y - offset);
        }
    }
}