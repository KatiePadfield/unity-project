using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FreezeObject : MonoBehaviour
{

    public StarterAssets.FirstPersonController player;
    public GameObject intro;
    public GameObject exitMenu;

    
    //all movement froze on start
    void Start () {

        player.MoveSpeed = 0;
        player.RotationSpeed = 0;

    }

    void Update () {
// when not in UI player can move again
        if (!intro.activeSelf && !exitMenu.activeSelf) {

            player.MoveSpeed = 4.0f;
            player.RotationSpeed = 1.0f;

        } 
// when exit menu is shown player is froze again           
        if (exitMenu.activeSelf) {

            player.MoveSpeed = 0;
            player.RotationSpeed = 0;
        } 


        
         
    }
}
