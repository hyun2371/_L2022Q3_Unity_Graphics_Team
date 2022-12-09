using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetJewel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            print("보석을 획득하셨습니다");
            GameObject.Find("JewelText").GetComponent<ManageJewelCount>().AddJewelCount();
            GameObject.Find("Jewels").GetComponent<AudioSource>().Play();

            Destroy(gameObject);
        }
    }
}
