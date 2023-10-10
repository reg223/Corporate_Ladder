using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public GameHandler2 gameHandlerObj;
    // Start is called before the first frame update
    void Start()
    {
        gameHandlerObj = GameObject.FindWithTag("GameHandler2").GetComponent<GameHandler2>();
    }

    public void OnTriggerEnter2D (Collider2D other){
        if (other.gameObject.tag == "Player"){
            GetComponent<Collider2D>().enabled = false;
            //GetComponent< AudioSource>().Play();
            GameObject.FindWithTag("GameHandler2").GetComponent<GameHandler2>().EndScene();
        }
    }
}
