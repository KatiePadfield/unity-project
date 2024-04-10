using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{

    public GameObject MessagePannel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenMessagePannel(string text){

        MessagePannel.SetActive(true);

    }
    
    public void CloseMessagePannel(string text){

        MessagePannel.SetActive(false);
        
    }

}
