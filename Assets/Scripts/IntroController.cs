using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroController : MonoBehaviour
{
      public GameObject intro;

   void Start() {
   
   Cursor.visible = true;
   
   }
   
   public void HideIntro() {
   
   intro.SetActive(false);
   Cursor.lockState = CursorLockMode.Locked;
   Cursor.visible = false;
   
   }
}
