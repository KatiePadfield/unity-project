using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroController : MonoBehaviour
{
   
   public GameObject intro;
   public GameObject info;

   void Start() {
   
   Cursor.visible = true;
   
   }
// when button is pressed intro is hidden and and cursor is locked and hidden again
   public void HideIntro() {
   
   intro.SetActive(false);
   Cursor.lockState = CursorLockMode.Locked;
   Cursor.visible = false;
   
   }
//shows info whne info button is pressed
   public void ShowInfo() {
   
   info.SetActive(true);
   
   }
}
