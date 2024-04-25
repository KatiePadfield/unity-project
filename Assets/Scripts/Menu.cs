using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{


    public GameObject mainMenu;
    public GameObject infoButton;

   void Start() {
   
   Cursor.lockState = CursorLockMode.None;
 
   
   }
   
   public void StartGame() {
   
   mainMenu.SetActive(false);
  
   
   }

   public void Info() {

   infoButton.SetActive(false);


   }
}