using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity;
using UnityEngine.UI;
public class Spawnitems : MonoBehaviour
 { //   public  Text scoreText;
   //  public int _score = 0;
   
   private void OnCollisionExit(Collision other) {
    Debug.Log("Col");
    
 }
private void OnTriggerExit(Collider other) {
    if(other.gameObject.name == "Player")
    Destroy(gameObject);
   // _score++;
   // if   (_score != 5) 
   //      scoreText.text = "Score: " + _score;
        
   //  else
   //   scoreText.text = "Congratulations! " + _score;
 }

//  private void OnTriggerEnter(Collider other){
//     if(other.gameObject.name == "Player")
//   GetComponent<Sozdanie1>();
//  }
}