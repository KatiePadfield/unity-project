using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot : MonoBehaviour
{
        public GameObject beePivot ;

    void Update()
    {  
        transform.RotateAround(beePivot.transform.position, Vector3.up, 30 * Time.deltaTime);
    }
}

