using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chimes : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip chimes;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("chime");

        GetComponent<AudioSource>().PlayOneShot(chimes);
    }
}
