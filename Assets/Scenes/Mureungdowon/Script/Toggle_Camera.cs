using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle_Camera : MonoBehaviour
{
    public GameObject Fps;
    bool isOn;
    public GameObject mention;
    public GameObject camera_mention;

    public void OnValueChanged()
    {
        isOn = GetComponent<Toggle>().isOn;
        if (isOn)
        {
            Fps.SetActive(true);
            mention.SetActive(true);
            camera_mention.SetActive(false);
        }
        else 
        {
            Fps.SetActive(false);
        }
    }

}
