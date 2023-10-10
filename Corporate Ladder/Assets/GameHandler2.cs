using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler2 : MonoBehaviour {

      public GameObject scoreText;
      private GameObject player;
      private string sceneName;
      private static int playerScore = 0;

      void Start(){
            UpdateScore();
            player = GameObject.FindWithTag("Player");
      }

      public void AddScore(int points){
            playerScore += points;
            UpdateScore();
      }

      void UpdateScore(){
            Text scoreTextB = scoreText.GetComponent<Text>();
            if (SceneManager.GetActiveScene().name == "EndScene") {
                  scoreTextB.text = "Final Salary: $" + playerScore;
            } else {
                  scoreTextB.text = "Salary: $" + playerScore;
            }
      }

      public void StartGame(){
            playerScore = 0;
            //NOTE: CHANGE SCENE NAME ONCE GAME SCENE IS MADE
            SceneManager.LoadScene("Eleanor_Workspace");
      }

      public void QuitGame(){
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #else
            Application.Quit();
            #endif
      }

      public void Credits(){
            SceneManager.LoadScene("CreditScene");
      }

      public void MainMenu(){
            SceneManager.LoadScene("MainMenu");
      }
}