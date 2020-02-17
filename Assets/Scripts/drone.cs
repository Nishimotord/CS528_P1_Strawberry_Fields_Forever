using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drone : MonoBehaviour
{
    Light l;
    float speed;
    float H, S_, V_ ,S, V;
    public float initialY;
    // Start is called before the first frame update
    void Start()
    {
        initialY = this.transform.position.y;

        l = this.GetComponentInChildren<Light>();
        Color.RGBToHSV(l.color, out H, out S_, out V_);
        speed = Random.value/10;
    }

    // Update is called once per frame
    void Update()
    {
        Color.RGBToHSV(l.color, out H, out S, out V);
        l.color = Color.HSVToRGB((H + speed) % 255, S_, V_);
    }
}
