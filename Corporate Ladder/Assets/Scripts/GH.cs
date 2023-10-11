using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour {

      private GameObject player;
      public static int playerHealth = 100;
      public int StartPlayerHealth = 100;
      public GameObject healthText;

      public static int gotTokens = 0;
      public GameObject tokensText;

      public bool isDefending = false;

      public static bool stairCaseUnlocked = false;
      //this is a flag check. Add to other scripts: GameHandler.stairCaseUnlocked = true;

      private string sceneName;
      public static string lastLevelDied;  //allows replaying the Level where you died

      void Start(){
            player = GameObject.FindWithTag("Player");

      }

      public void playerGetTokens(int newTokens){
            gotTokens += newTokens;
            updateStatsDisplay();
      }

    //   public void playerGetHit(int damage){
    //        if (isDefending == false){
    //               playerHealth -= damage;
    //               if (playerHealth >=0){
    //                     updateStatsDisplay();
    //               }
    //               if (damage > 0){
    //                     //player.GetComponent<PlayerHurt>().playerHit();       //play GetHit animation
    //               }
    //         }

    //        if (playerHealth > StartPlayerHealth){
    //               playerHealth = StartPlayerHealth;
    //               updateStatsDisplay();
    //         }

    //        if (playerHealth <= 0){
    //               playerHealth = 0;
    //               updateStatsDisplay();
    //               playerDies();
    //         }
    //   }

      public void updateStatsDisplay(){


            Text tokensTextTemp = tokensText.GetComponent<Text>();
            tokensTextTemp.text = "GOLD: " + gotTokens;
      }
}