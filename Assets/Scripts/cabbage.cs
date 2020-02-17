using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabbage : MonoBehaviour
{

    AudioSource a;
    // Start is called before the first frame update
    void Start()
    {
        a = GameObject.Find("CabbageTrigger").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "terrain" && !a.isPlaying)
        {
            a.Play();
        }
    }
}
