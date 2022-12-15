using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint_Dungeon : MonoBehaviour
{
    public GameObject hint;
    public bool isOn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (!isOn)
                hint.SetActive(true);
            else
                hint.SetActive(false);
            isOn = !isOn;
        }
    }
}
