using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFlower : MonoBehaviour
{
    public GameObject flower;
    public GameObject start_mention;

    private void OnTriggerEnter(Collider other)
    {
        flower.SetActive(true);
        start_mention.SetActive(false);
    }
}
