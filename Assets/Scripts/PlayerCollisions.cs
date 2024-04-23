using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
  
    public GameObject PressF;
    
    public Inventory inventory;

    public GameObject ladder;
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

    private void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        float distance = 5.0f;

        //check if it hits anything
        if (Physics.Raycast(ray, out hit, distance)) 
        {
          
          if (hit.transform.tag.Equals("PlaceHolder")) {

            if (GameObject.Find("HUD").GetComponent<Inventory>().items[GameObject.Find("HUD").GetComponent<Inventory>().currentSlot] != null) {
                
            if (Input.GetMouseButtonDown(0)){
                GameObject placeable = null; 
                switch (GameObject.Find("HUD").GetComponent<Inventory>().items[GameObject.Find("HUD").GetComponent<Inventory>().currentSlot]) {
                    case "MyLadderObject":
                    placeable = Instantiate(ladder);
                    placeable.transform.position = hit.transform.position;
                    Debug.Log("placed");
                   
                      //Destroy();
                    break;
                }
              
            }
            }
            
          }

        }
    }
}


