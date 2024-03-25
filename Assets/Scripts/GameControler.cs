using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameControler : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject ui; 
    void Start()
    {
        ui.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            ui.SetActive(true);   
            Cursor.lockState = CursorLockMode.None;
             Cursor.visible = true;    
             }


             
    }

    public void CloseUI() {
        ui.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
             Cursor.visible = false;
    }

    public void TextUpdate() {

        GameObject.Find("title").GetComponent<TMP_Text>().text = "bye";
    }
}
