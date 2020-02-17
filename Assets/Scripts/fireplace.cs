using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireplace : MonoBehaviour
{
    public Light fire;
    float val = .01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        val = val < 0 && fire.intensity < .5 ? Random.value / 10 : fire.intensity > 1.5 && val > 0 ? -Random.value / 10 : val;

        fire.intensity += val;
    }
}
