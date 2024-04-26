using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerCollisions : MonoBehaviour
{
  
    public GameObject PressF;
    
    public Inventory inventory;

    public GameObject ladder;
    public GameObject whiteFlower;
    public GameObject pinkFlower;
    public GameObject yellowFlower;
    public GameObject blueFlower;
    public GameObject tree;


    public List<GameObject> placeHolderItems = new List<GameObject>();

    public bool triggerFKey;
    // Start is called before the first frame update

    public void OnTriggerStay(Collider hit)
    {

       
    
       if(triggerFKey) {
         Debug.Log(hit.gameObject.name);
         if (hit.gameObject.tag.Equals("Collectable")) {
        GameObject.Find("HUD").GetComponent<Inventory>().AddItem(hit.gameObject);
        triggerFKey = false;
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


        if(Input.GetKeyDown(KeyCode.F)) {
            triggerFKey = true;
         }

        if (inventory.items[inventory.currentSlot] != null) {
             foreach (GameObject placeHolder in placeHolderItems) {

                if (placeHolder != null) {
                    
                    placeHolder.SetActive(true);

                }
                
               }
        } else {

               foreach (GameObject placeHolder in  placeHolderItems) {
                  
                  if (placeHolder != null) {
                    
                    placeHolder.SetActive(false);

                }
               }
        }


        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        float distance = 5.0f;

        //check if it hits anything


       
        if (Physics.Raycast(ray, out hit, distance)) 
        {
          
           Debug.Log(hit.transform.gameObject);

          if (hit.transform.tag.Equals("PlaceHolder")) {
            Inventory inventory = GameObject.Find("HUD").GetComponent<Inventory>();

            if (inventory.items[inventory.currentSlot] != null) {

           
            
                
            if (Input.GetMouseButtonDown(0)){
                GameObject placeable = null;
                switch (inventory.items[inventory.currentSlot]) {
                    case "MyLadderObject":
                    placeable = Instantiate(ladder);
                    placeable.transform.position = hit.transform.position;
                    

                    Destroy(hit.transform.gameObject);
                  
                   inventory.items[inventory.currentSlot] = null;
                   inventory.images[inventory.currentSlot].sprite = null;

                    break;

                    case "MyWhiteFlower":
                    placeable = Instantiate(whiteFlower);
                    placeable.transform.position = hit.transform.position;
                    

                    Destroy(hit.transform.gameObject);
                  
                   inventory.items[inventory.currentSlot] = null;
                   inventory.images[inventory.currentSlot].sprite = null;

                    break;

                      
                    case "MyPinkFlower":
                    placeable = Instantiate(pinkFlower);
                    placeable.transform.position = hit.transform.position;
                    

                    Destroy(hit.transform.gameObject);
                  
                   inventory.items[inventory.currentSlot] = null;
                   inventory.images[inventory.currentSlot].sprite = null;

                    break;

                    case "MyYellowFlower":
                    placeable = Instantiate(yellowFlower);
                    placeable.transform.position = hit.transform.position;
                    

                    Destroy(hit.transform.gameObject);
                  
                   inventory.items[inventory.currentSlot] = null;
                   inventory.images[inventory.currentSlot].sprite = null;

                    break;


                    case "MyBlueFlower":
                    placeable = Instantiate(blueFlower);
                    placeable.transform.position = hit.transform.position;
                        

                     Destroy(hit.transform.gameObject);
                    
                    inventory.items[inventory.currentSlot] = null;
                    inventory.images[inventory.currentSlot].sprite = null;

                    break;

                    case "MySeed":
                    placeable = Instantiate(tree);
                    placeable.transform.position = hit.transform.position;
                        

                     Destroy(hit.transform.gameObject);
                    
                    inventory.items[inventory.currentSlot] = null;
                    inventory.images[inventory.currentSlot].sprite = null;

                    break;



                }
              
            }
            }
            
          }

        }
    }
}


