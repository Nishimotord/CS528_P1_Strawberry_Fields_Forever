using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject Player, DayScene, NightScene;
    public GameObject[] Locations;
    public Light Lighting;
    private GameObject[] lightbulbs;
    private GameObject[] dronelights;

    // Start is called before the first frame update
    void Start()
    {
        DayScene.SetActive(true);
        NightScene.SetActive(false);
        lightbulbs = GameObject.FindGameObjectsWithTag("bulb");
        dronelights = GameObject.FindGameObjectsWithTag("drone_light");
        for (int i = 0; i < lightbulbs.Length; i++)
        {
            lightbulbs[i].GetComponent<Light>().range = 16;
            lightbulbs[i].GetComponent<Light>().intensity = 0;
        }
        for(int j = 0; j < dronelights.Length; j++)
        {
            //dronelights[j].GetComponent<Light>().intensity = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleScene()
    {
        DayScene.SetActive(!DayScene.activeSelf);
        NightScene.SetActive(!NightScene.activeSelf);
        Lighting.intensity = NightScene.activeSelf ? 0 : 1;
        for(int i = 0; i < lightbulbs.Length; i++)
        {
            lightbulbs[i].GetComponent<Light>().intensity = NightScene.activeSelf ? 2 : 0;
        }
        for (int j = 0; j < dronelights.Length; j++)
        {
            //dronelights[j].GetComponent<Light>().intensity = NightScene.activeSelf ? 1 : 0;
        }

    }

    public void JumpTo(int val)
    {
        Player.transform.position = Locations[val].transform.position;
        Player.transform.rotation = Locations[val].transform.rotation;
    }
}
