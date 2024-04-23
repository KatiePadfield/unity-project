using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour
{

     public void OnTriggerEnter(Collider hit) {

    
        if(hit.gameObject.name.Equals("Door")) {
           SceneManager.LoadScene("main", LoadSceneMode.Single);
        }

        Debug.Log(hit.gameObject.name);
        if(hit.gameObject.name.Equals("DoorCollider")) {
           SceneManager.LoadScene("House", LoadSceneMode.Single);
        }

    }
   
}
