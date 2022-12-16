using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class final_mention : MonoBehaviour
{
    public GameObject Mention;

    private void OnTriggerEnter(Collider other)
    {
        Mention.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        Mention.SetActive(false);
    }
}

