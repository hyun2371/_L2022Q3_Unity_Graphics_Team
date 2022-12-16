using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexSceneController_Mureungdowon : MonoBehaviour
{
    public GameObject text;
    public bool isOn;

    void Start()
    {
        isOn = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            if (isOn)
            {
                text.SetActive(false);
                isOn = false;
            }
            else
            {
                text.SetActive(true);
                isOn = true;
            }
        }
    }
}
