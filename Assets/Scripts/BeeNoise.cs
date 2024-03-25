using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeNoise : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip beeNoise;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("bee");

        GetComponent<AudioSource>().PlayOneShot(beeNoise);
    }
}
