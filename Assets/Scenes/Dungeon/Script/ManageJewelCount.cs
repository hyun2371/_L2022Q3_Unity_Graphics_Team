using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageJewelCount : MonoBehaviour
{
    public int jewelCount;

    public void AddJewelCount()
    {
        jewelCount++;
        DisplayJewelCount(jewelCount);

    }

    void DisplayJewelCount(int jewelCount)
    {
        GameObject.Find("JewelValue").GetComponent<Text>().text = jewelCount.ToString() + " / 4";

    }
}
