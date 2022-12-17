using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageJewelCount : MonoBehaviour
{
    public int jewelCount;
    public GameObject obstacle;
    public Text boxText;

    private void Update()
    {
        if (jewelCount == 4&& obstacle!=null)
        {
            obstacle.SetActive(false);
            boxText.text = "Go in front of the mirror";
        }
    }

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
