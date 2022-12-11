using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFlower : MonoBehaviour
{
    public GameObject Mention;

    private void OnTriggerEnter(Collider other)
    {
        Mention.SetActive(true);
    }
}
