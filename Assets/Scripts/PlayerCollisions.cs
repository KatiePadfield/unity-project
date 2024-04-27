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

    
    public GameObject Tick1;
    public GameObject Tick2;
    public GameObject Tick3;
    public GameObject Tick4;
    public GameObject Tick5;

    public AudioClip popSound;


    public List<GameObject> placeHolderItems = new List<GameObject>();

    public bool triggerFKey;
   

    public void OnTriggerStay(Collider hit)
    {

// if f is pressed when in colldier add object to inventory        
       if(triggerFKey) {
        if (hit.gameObject.tag.Equals("Collectable")) {
        GameObject.Find("HUD").GetComponent<Inventory>().AddItem(hit.gameObject);
        triggerFKey = false;
       }
      }
    }

// when enter collider of collectable show press f prompt
    public void OnTriggerEnter(Collider hit) {

        if(hit.gameObject.tag.Equals("Collectable")) {
           PressF.SetActive(true);
        }

    }
// when exit collider of collectable hide press f prompt
     public void OnTriggerExit(Collider hit) {

        if(hit.gameObject.tag.Equals("Collectable")) {
            PressF.SetActive(false);
        }

    }

    private void Update () {

//when f is pressed set triggerFKey to true
        if(Input.GetKeyDown(KeyCode.F)) {
            triggerFKey = true;
         }

// Check if there is an item in the current slot of the inventory 
        if (inventory.items[inventory.currentSlot] != null) {
             foreach (GameObject placeHolder in placeHolderItems) {
// Shows place hodlers
                if (placeHolder != null) {
                    
                    placeHolder.SetActive(true);

                }
                
               }
        } else {
// Hides place hodlers
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
          
//if ray hits object with PlaceHolder Tag
          if (hit.transform.tag.Equals("PlaceHolder")) {
            Inventory inventory = GameObject.Find("HUD").GetComponent<Inventory>();
//if intventory slot isnt null
            if (inventory.items[inventory.currentSlot] != null) {
//if left mouse button is down           
            if (Input.GetMouseButtonDown(0)){
                GameObject placeable = null; 

// when a slot contians an item listed below              
                switch (inventory.items[inventory.currentSlot]) {

                    case "MyWhiteFlower":
//placebale object instantiate and postion set to place holders position
                    placeable = Instantiate(whiteFlower);
                    placeable.transform.position = hit.transform.position;
                    
// destroy plac eholder
                    Destroy(hit.transform.gameObject);
// set current inventory slot to null and remove sprite                  
                    inventory.items[inventory.currentSlot] = null;
                    inventory.images[inventory.currentSlot].sprite = null;
// tick box is turned on
                    Tick1.SetActive(true);
// pop audio is played when place
                    GetComponent<AudioSource>().clip = popSound;
                    GetComponent<AudioSource>().Play();

                    break;

                      
                    case "MyPinkFlower":
                    placeable = Instantiate(pinkFlower);
                    placeable.transform.position = hit.transform.position;
                    

                    Destroy(hit.transform.gameObject);
                  
                    inventory.items[inventory.currentSlot] = null;
                    inventory.images[inventory.currentSlot].sprite = null;

                    Tick2.SetActive(true);
                    GetComponent<AudioSource>().clip = popSound;
                    GetComponent<AudioSource>().Play();
                   

                    break;

                    case "MyYellowFlower":
                    placeable = Instantiate(yellowFlower);
                    placeable.transform.position = hit.transform.position;
                    

                    Destroy(hit.transform.gameObject);
                  
                    inventory.items[inventory.currentSlot] = null;
                    inventory.images[inventory.currentSlot].sprite = null;

                    Tick3.SetActive(true);

                    GetComponent<AudioSource>().clip = popSound;
                    GetComponent<AudioSource>().Play();

                    break;


                    case "MyBlueFlower":
                    placeable = Instantiate(blueFlower);
                    placeable.transform.position = hit.transform.position;
                        

                    Destroy(hit.transform.gameObject);
                    
                    inventory.items[inventory.currentSlot] = null;
                    inventory.images[inventory.currentSlot].sprite = null;

                    Tick4.SetActive(true);
                    
                    GetComponent<AudioSource>().clip = popSound;
                    GetComponent<AudioSource>().Play();


                    break;

                    case "MySeed":
                    placeable = Instantiate(tree);
                    placeable.transform.position = hit.transform.position;
                        

                    Destroy(hit.transform.gameObject);
                    
                    inventory.items[inventory.currentSlot] = null;
                    inventory.images[inventory.currentSlot].sprite = null;

                    Tick5.SetActive(true);

                    GetComponent<AudioSource>().clip = popSound;
                    GetComponent<AudioSource>().Play();

                    break;

                    }
                }
            }
          }
        }
    }
}


