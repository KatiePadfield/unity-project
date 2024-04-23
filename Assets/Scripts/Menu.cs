using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject HUD;

   void Start() {
   
   Cursor.lockState = CursorLockMode.None;
   Cursor.visible = true;
   
   }
   
   public void HideIntro() {
   
   HUD.SetActive(false);
   Cursor.lockState = CursorLockMode.Locked;
   Cursor.visible = false;
   
   }
}