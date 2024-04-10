using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
  
    public GameObject PressF;
    
    public Inventory inventory;
    // Start is called before the first frame update

    public void OnTriggerStay(Collider hit)
    {

       
    
       if(Input.GetKeyDown(KeyCode.F)) {
         Debug.Log(hit.gameObject.name);
         if (hit.gameObject.tag.Equals("Collectable")) {
        GameObject.Find("HUD").GetComponent<Inventory>().AddItem(hit.gameObject);
       }
      }
    }


    public void OnTriggerEnter(Collider hit) {

        if(hit.gameObject.tag.Equals("Collectable")) {
           PressF.SetActive(true);
        }

    }

     public void OnTriggerExit(Collider hit) {

        if(hit.gameObject.tag.Equals("Collectable")) {
            PressF.SetActive(false);
        }

    }
}

