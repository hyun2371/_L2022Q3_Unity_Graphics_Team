using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active_flower : MonoBehaviour
{
    public GameObject gameobject;
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        gameObject.SetActive(false);
    }
}
