using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{
    Material water;
    // Start is called before the first frame update
    void Start()
    {
        water = this.GetComponent<UnityEngine.Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        water.mainTextureOffset = new Vector2((water.mainTextureOffset.x + .01f)%2, water.mainTextureOffset.y);
    }
}
