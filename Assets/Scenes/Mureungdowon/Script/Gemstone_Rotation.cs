using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gemstone_Rotation : MonoBehaviour
{
    public GameObject GameObject;

    private void OnTriggerEnter(Collider other)
    {
        GameObject.GetComponent<Animator>().SetInteger("State", 1);
    }
    private void OnTriggerExit(Collider other)
    {
        GameObject.GetComponent<Animator>().SetInteger("State", 0);
    }
}
