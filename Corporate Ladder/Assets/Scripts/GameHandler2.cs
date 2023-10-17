using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler2 : MonoBehaviour {

      public GameObject scoreText;
      private GameObject player;
      private string sceneName;
      public static int playerScore = 0;
      public static int levelScore = 0;
      public int startScore = 0;
      public GameObject targetSalText;
      public int targetSalary = 0;

      void Start(){
            UpdateScore();
            player = GameObject.FindWithTag("Player");
            Text targetSalTextB = targetSalText.GetComponent<Text>();
            targetSalTextB.text = "Target Salary: $" + targetSalary;
      }

      void Update(){
            levelScore = Math.Max(levelScore, startScore);
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
            Time.timeScale = 1f;
            GameHandler_PauseMenu.GameisPaused = false;
            playerScore = 0;
            SceneManager.LoadScene("Mailroom");
      }

      public void ReplayLevel(){
            Time.timeScale = 1f;
            GameHandler_PauseMenu.GameisPaused = false;
            playerScore = levelScore;
            if (SceneManager.GetActiveScene().name != "LoseScene"){
                  
                  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            } else {
                  playerScore = 0;
                  SceneManager.LoadScene("Mailroom");
            }
            // SceneManager.LoadScene("lastLevelDied");
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

      public void EndScene(){
            SceneManager.LoadScene("EndScene");
      }
}