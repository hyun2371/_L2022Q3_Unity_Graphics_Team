using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dungeon_start_light_on : MonoBehaviour
{
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light4;
    public GameObject Light5;
    public GameObject followlight;
    public GameObject followlight1;
    public GameObject followlight2;
    public GameObject followlight3;
    public GameObject followlight4;
    public GameObject followlight5;
    public GameObject followlight6;
    public GameObject followlight7;
    bool isOn;

    // Start is called before the first frame update
    void Start()
    {
        isOn = false;
        Light1.SetActive(isOn);
        Light2.SetActive(isOn);
        Light3.SetActive(isOn);
        Light4.SetActive(isOn);
        Light5.SetActive(isOn);
        followlight.SetActive(isOn);
        followlight1.SetActive(isOn);
        followlight2.SetActive(isOn);
        followlight3.SetActive(isOn);
        followlight4.SetActive(isOn);
        followlight5.SetActive(isOn);
        followlight6.SetActive(isOn);
        followlight7.SetActive(isOn);
    }

    // Update is called once per frame

    private void OnMouseDown()
    {
        print(gameObject.name + "mouse down");
        isOn = !isOn;
        Light1.SetActive(isOn);
        Light2.SetActive(isOn);
        Light3.SetActive(isOn);
        Light4.SetActive(isOn);
        Light5.SetActive(isOn);
        followlight.SetActive(isOn);
        followlight1.SetActive(isOn);
        followlight2.SetActive(isOn);
        followlight3.SetActive(isOn);
        followlight4.SetActive(isOn);
        followlight5.SetActive(isOn);
        followlight6.SetActive(isOn);
        followlight7.SetActive(isOn);

    }
}
