using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windmills_showText : MonoBehaviour
{
    public GameObject panel;
    private bool isFirstEnter = true;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && isFirstEnter == true)
        {
            panel.SetActive(true);
        }

        if (isFirstEnter == true)
            isFirstEnter = false;
        
    }

    private void OnTriggerExit(Collider other)
    {
        isFirstEnter = true;
    }

    public void closePanel()
    {
        print("close Panel");
        panel.SetActive(false);
    }
}
