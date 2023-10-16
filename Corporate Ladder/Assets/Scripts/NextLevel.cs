using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class NextLevel : MonoBehaviour {

    public GameObject nextLevelUI;

    void Awake (){
        nextLevelUI.SetActive(true);
    }

    void Update (){
        if (Input.anyKey){
            nextLevelUI.SetActive(false);
        }
    }
}