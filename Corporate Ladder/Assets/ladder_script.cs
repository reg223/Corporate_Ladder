using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class LadderMove : MonoBehaviour {


        private Transform playerTrans;
        private Rigidbody2D playerRB;
        public float upSpeed = 10f;
        private Vector3 vMove;

        public bool canLadder = false;

        public bool canJump;

       void Start(){
              if (GameObject.FindWithTag("Player") != null){
                     playerTrans = GameObject.FindWithTag("Player").GetComponent<Transform>();
                     playerRB = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();

                     
                     canJump = GameObject.FindWithTag("Player").GetComponent<PlayerJummp>().canJump;
              }
       }

       void Update(){
              vMove = new Vector3(0.0f, Input.GetAxis("Vertical"), 0.0f);
              if (canLadder == true){
                     playerTrans.position = playerTrans.position + vMove * upSpeed * Time.deltaTime;
              }
       }

        void OnTriggerStay2D(Collider2D other){
              if (other.gameObject.tag == "Player"){
                     canLadder = true;
                     playerRB.gravityScale = 0;
                     canJump= true;
                     // if game has jumping, add bool to disable it, and set true here
              }
        }

        void OnTriggerExit2D(Collider2D other){
              if (other.gameObject.tag == "Player"){
                     canLadder = false;
                     playerRB.gravityScale = 15;
                     canJump = false;
                     // if game has jumping, add bool to disable it, and set false here
              }
        }

}