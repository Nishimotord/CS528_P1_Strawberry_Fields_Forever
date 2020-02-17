using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droneManager : MonoBehaviour
{
    public PhysicsButton button;
    public GameObject[] drones;
    public AudioSource droneAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (button.pressed)
        {
            drones[0].transform.position = new Vector3(drones[0].transform.position.x, drones[2].GetComponent<drone>().initialY, drones[0].transform.position.z);
            drones[1].transform.position = new Vector3(drones[1].transform.position.x, drones[3].GetComponent<drone>().initialY, drones[1].transform.position.z);
            drones[2].transform.position = new Vector3(drones[2].transform.position.x, drones[0].GetComponent<drone>().initialY, drones[2].transform.position.z);
            drones[3].transform.position = new Vector3(drones[3].transform.position.x, drones[1].GetComponent<drone>().initialY, drones[3].transform.position.z);
            droneAudio.pitch = .9f;
        }
        else if (!button.pressed)
        {
            droneAudio.pitch = 1.1f;
            for (int i = 0; i < drones.Length; i++)
            {
                drones[i].transform.position = new Vector3(drones[i].transform.position.x, drones[i].GetComponent<drone>().initialY, drones[i].transform.position.z);
            }

        }

    }
}
