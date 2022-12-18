using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageKey : MonoBehaviour
{
    public int keyCount;
    public GameObject gateway;
    public GameObject panel;
    

    private void Update()
    {
        if (keyCount == 3)
        {
            gateway.SetActive(true);
            if (panel != null)
            {
                panel.SetActive(true);
                Invoke("destroyPanel", 3f);
            }
        }
    }

    public void AddKeyCount()
    {
        keyCount++;
        DisplayKeyCount(keyCount);

    }

    void DisplayKeyCount(int keyCount)
    {
        GameObject.Find("KeyValue").GetComponent<Text>().text = keyCount.ToString() + " / 3";

    }

    private void destroyPanel()
    {
        Destroy(panel);
    }
}
