using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FreezeObject : MonoBehaviour
{

    public StarterAssets.FirstPersonController player;
    public GameObject intro;

    void Start () {

        player.MoveSpeed = 0;
        player.RotationSpeed = 0;

    }

    void Update () {

        if ( !intro.activeSelf ) {

             player.MoveSpeed = 4.0f;
            player.RotationSpeed = 1.0f;

        }
         
    }
}
