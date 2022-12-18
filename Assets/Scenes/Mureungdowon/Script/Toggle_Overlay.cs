using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Toggle_Overlay : MonoBehaviour
{
    public GameObject Multipass_camera;
    bool isOn;
    public void OnValueChanged()
    {
        isOn = GetComponent<Toggle>().isOn;
        if (isOn)
        {
            Multipass_camera.SetActive(true);
        }
        else
        {
            Multipass_camera.SetActive(false);
        }
    }
}
