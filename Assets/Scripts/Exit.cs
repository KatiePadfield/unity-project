using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{

    public GameObject exitMenu;

//when escape is pressed UI quit menu shows and cursor locked and shown
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            
            exitMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

    }

//Yes button pressed will make game quit
    public void ExitCode() {

        Application.Quit();
    }

//No button removes UI and goes back to scene 
    public void Return() {

            exitMenu.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        
    }
}
