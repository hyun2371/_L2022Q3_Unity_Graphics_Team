using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Contriller : MonoBehaviour
{
    public GameObject Pivot;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        Pivot.GetComponent<Animator>().SetInteger("State", 1);
    }
    private void OnTriggerExit(Collider other)
    {
        Pivot.GetComponent<Animator>().SetInteger("State", 2);
    }

    // Update is called once per frame

}
