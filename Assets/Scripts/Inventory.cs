using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{


    public int currentSlot;

    public GameObject highlight;

    public GameObject hand;

    public Sprite handImage;

    public GameObject inventoryPanel;
    public List<Image> images = new List<Image>();

    public Dictionary<int, string> items = new Dictionary<int, string>
{
    { 0, null },
    { 1, null },
    { 2, null },
    { 3, null },
    { 4, null },
    { 5, null },
    { 6, null },
    { 7, null },
    { 8, null },
    { 9, null }
};

    public void AddItem(GameObject gameObject)
    {
        bool added = false;
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] == null)
            {
                items[i] = gameObject.GetComponent<Item>().name;
                images[i].sprite = gameObject.GetComponent<Item>().image;

                Destroy(gameObject);
                GameObject.Find("PlayerCapsule").GetComponent<PlayerCollisions>().PressF.SetActive(false);
                added = true;
                break;
            }

            
        }

        if (!added)
        {
            Debug.LogWarning("Inventory is full. Cannot add item.");
        }
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.Alpha1))
        {

            highlight.transform.position = inventoryPanel.transform.GetChild(0).position;

            currentSlot = 0;


        }

        if (Input.GetKey(KeyCode.Alpha2))
        {

            highlight.transform.position = inventoryPanel.transform.GetChild(1).position;
            currentSlot = 1;


             if (items[1] != null)  
            {
             images[1].sprite = gameObject.GetComponent<Item>().image;
            }    
            if (items[1] == null)  
            {
              hand.GetComponent<Image>().sprite = handImage; 
            }   
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {

            highlight.transform.position = inventoryPanel.transform.GetChild(2).position;
            currentSlot = 2;


              if (items[2] != null)  
            {
             images[2].sprite = gameObject.GetComponent<Item>().image;
            }    
            if (items[2] == null)  
            {
              hand.GetComponent<Image>().sprite = handImage; 
            }     
        }

        if (Input.GetKey(KeyCode.Alpha4))
        {

            highlight.transform.position = inventoryPanel.transform.GetChild(3).position;
            currentSlot = 3;

              if (items[3] != null)  
            {
             images[3].sprite = gameObject.GetComponent<Item>().image;
            }    
            if (items[3] == null)  
            {
              hand.GetComponent<Image>().sprite = handImage; 
            }    
        }

        if (Input.GetKey(KeyCode.Alpha5))
        {


            highlight.transform.position = inventoryPanel.transform.GetChild(4).position;
            currentSlot = 4;

             if (items[4] != null)  
            {
             images[4].sprite = gameObject.GetComponent<Item>().image;
            }    
            if (items[4] == null)  
            {
              hand.GetComponent<Image>().sprite = handImage; 
            }    
        }

        if (Input.GetKey(KeyCode.Alpha6))
        {

            highlight.transform.position = inventoryPanel.transform.GetChild(5).position;
            currentSlot = 5;

              if (items[5] != null)  
            {
             images[5].sprite = gameObject.GetComponent<Item>().image;
            }    
            if (items[5] == null)  
            {
              hand.GetComponent<Image>().sprite = handImage; 
            }   
        }

        if (Input.GetKey(KeyCode.Alpha7))
        {

            highlight.transform.position = inventoryPanel.transform.GetChild(6).position;
            currentSlot = 6;

              if (items[6] != null)  
            {
             images[6].sprite = gameObject.GetComponent<Item>().image;
            }    
            if (items[6] == null)  
            {
              hand.GetComponent<Image>().sprite = handImage; 
            }     
        }
        if (Input.GetKey(KeyCode.Alpha8))
        {

            highlight.transform.position = inventoryPanel.transform.GetChild(7).position;
            currentSlot = 7;

              if (items[7] != null)  
            {
             images[7].sprite = gameObject.GetComponent<Item>().image;
            }    
            if (items[7] == null)  
            {
              hand.GetComponent<Image>().sprite = handImage; 
            }    
        }
        if (Input.GetKey(KeyCode.Alpha9))
        
        {

            highlight.transform.position = inventoryPanel.transform.GetChild(8).position;
            currentSlot = 8;

              if (items[8] != null)  
            {
             images[8].sprite = gameObject.GetComponent<Item>().image;
            }    
            if (items[8] == null)  
            {
              hand.GetComponent<Image>().sprite = handImage; 
            }    
        }

          if (highlight.transform.position == inventoryPanel.transform.GetChild(0).position) {


            if (items[0] != null)  
            {

              hand.GetComponent<Image>().sprite = images[0].sprite; 

            }   if (items[0] == null)  
            {

              hand.GetComponent<Image>().sprite = handImage; 
            }   
          }

          if (highlight.transform.position == inventoryPanel.transform.GetChild(1).position) {


            if (items[2] != null)  
            {

              hand.GetComponent<Image>().sprite = images[2].sprite; 

            }   if (items[2] == null)  
            {

              hand.GetComponent<Image>().sprite = handImage; 
            }   
          }

  if (highlight.transform.position == inventoryPanel.transform.GetChild(2).position) {


            if (items[3] != null)  
            {

              hand.GetComponent<Image>().sprite = images[3].sprite; 

            }   if (items[3] == null)  
            {

              hand.GetComponent<Image>().sprite = handImage; 
            }   
          }
    }
}