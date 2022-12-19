using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexSceneController : MonoBehaviour
{

    public GameObject text1;
    public GameObject text2;
    public bool isOn;

    void Start()
    {
        isOn = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            if(isOn)
            {
                text1.SetActive(false);
                text2.SetActive(false);
                isOn = false;
            }
            else
            {
                text1.SetActive(true);
                text2.SetActive(true);
                isOn = true;
            }
        }
    }


}
