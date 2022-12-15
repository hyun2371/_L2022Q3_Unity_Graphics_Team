using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexSceneController_Dungeon : MonoBehaviour
{
    public GameObject text;
    public bool isOn;
    public GameObject hint;
    public bool isOn_hint;

    void Start()
    {
        isOn = false;
        isOn_hint = false;
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


        //hint
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (!isOn_hint)
                hint.SetActive(true);
            else
                hint.SetActive(false);
            isOn_hint = !isOn_hint;
        }
    }
}
