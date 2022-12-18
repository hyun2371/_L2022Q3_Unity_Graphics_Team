using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour
{
    public GameObject hint;
    public bool isOn;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!isOn)
                hint.SetActive(true);
            else
                hint.SetActive(false);
            isOn = !isOn;
        }
    }

}
