using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneChange : MonoBehaviour
{

   public GameObject Tick1;
   public GameObject Tick2;
   public GameObject Tick3;
   public GameObject Tick4;
   public GameObject Tick5;

   public GameObject prompt;

   public void OnTriggerEnter(Collider hit) {

// if player walks into door load main    
        if(hit.gameObject.name.Equals("Door")) {
           SceneManager.LoadScene("main", LoadSceneMode.Single);
        }

// if all tick boxs are complete
        if(Tick1.activeSelf && Tick2.activeSelf && Tick3.activeSelf && Tick4.activeSelf && Tick5.activeSelf) {
//if player walks to door laod final scene        
        if(hit.gameObject.name.Equals("DoorCollider")) {
           SceneManager.LoadScene("HouseEnd", LoadSceneMode.Single);
        }
// else if they only hit door without completing check lsit show the prompt
        } else if (hit.gameObject.name.Equals("DoorCollider")) {

         prompt.SetActive(true);
        }

    }
// when they exit door collider turn off prompt
   public void OnTriggerExit(Collider hit) {
      if (hit.gameObject.name.Equals("DoorCollider")) {

         prompt.SetActive(false);
        }
    }
   
}
