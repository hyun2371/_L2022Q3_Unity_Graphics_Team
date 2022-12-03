using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagePotion : MonoBehaviour
{
    private AudioSource PotionSound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            PotionSound = GameObject.Find("HealthBar").GetComponent<AudioSource>();
            PotionSound.Play();
            GameObject.Find("FPSController").GetComponent<ManageLife>().DrinkPotion();
            Destroy(gameObject, 0.1f);
        }
    }
}
