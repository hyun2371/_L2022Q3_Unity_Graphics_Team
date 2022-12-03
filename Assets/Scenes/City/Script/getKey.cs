using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getKey : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            print("키를 획득하셨습니다");
            GameObject.Find("KeyText").GetComponent<ManageKey>().AddKeyCount();
            GameObject.Find("KeyGroup").GetComponent<AudioSource>().Play();
            gameObject.SetActive(false);
            Destroy(gameObject, 0.5f);
        }
    }
}
