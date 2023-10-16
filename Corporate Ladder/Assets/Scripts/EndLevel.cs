using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public GameHandler2 gameHandler;
    public string NextLevel = "MainMenu";
    public int salaryCollected = 0;
    public int salaryNeeded = 0;
    public bool canPass;

    void Start(){
        gameHandler = GameObject.FindWithTag("GameHandler2").GetComponent<GameHandler2>();
        gameObject.GetComponent<Collider2D>().enabled = true;
    }

    void Update(){
        salaryNeeded = gameHandler.targetSalary;
        salaryCollected = GameHandler2.playerScore;
        if (salaryCollected >= salaryNeeded){
                canPass = true;
        }
        else {
            canPass = false;
        }
    }

    public void OnTriggerEnter2D (Collider2D other){
        if (other.gameObject.tag == "Player"){
            GetComponent<Collider2D>().enabled = false;
            //GetComponent< AudioSource>().Play();
            if(canPass) {
                SceneManager.LoadScene(NextLevel);
            } else {
                SceneManager.LoadScene("LoseScene");
            }
        }
    }
}
