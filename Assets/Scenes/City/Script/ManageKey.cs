using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageKey : MonoBehaviour
{
    int keyCount;

    public void AddKeyCount()
    {
        keyCount++;
        DisplayKeyCount(keyCount);

    }

    void DisplayKeyCount(int keyCount)
    {
        GameObject.Find("KeyValue").GetComponent<Text>().text = keyCount.ToString() + " / 2";

    }
}
