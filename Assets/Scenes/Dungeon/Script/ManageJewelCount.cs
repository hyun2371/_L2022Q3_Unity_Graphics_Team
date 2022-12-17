using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageJewelCount : MonoBehaviour
{
    public int jewelCount;
    public GameObject door_right;
    public GameObject door_left;
    public Text boxText;

    private void Update()
    {
        if (jewelCount == 4)
        {
            door_right.GetComponent<Animator>().SetBool("isCollected", true);
            door_left.GetComponent<Animator>().SetBool("isCollected", true);
            boxText.text = "Go in front of the mirror";
        }
        else
        {
            door_right.GetComponent<Animator>().SetBool("isCollected", false);
            door_left.GetComponent<Animator>().SetBool("isCollected", false);
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
