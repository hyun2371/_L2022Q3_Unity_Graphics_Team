using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle_MultiPass : MonoBehaviour
{
    public GameObject camera;
    public GameObject Multipass_camera;
    bool isOn;

    public void OnValueChanged()
    {
        isOn = GetComponent<Toggle>().isOn;
        if (isOn)
        {
            Multipass_camera.SetActive(true);
            camera.SetActive(false);
        }
        else
        {
            Multipass_camera.SetActive(false);
        }
    }
}
