using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat_move : MonoBehaviour
{
    public GameObject Pivot;

    //isTrigger�� üũ������ �� �Լ� �����
    private void OnTriggerEnter(Collider other)
    {
        //print("enter: " + other.name);
        Pivot.GetComponent<Animator>().SetInteger("State", 1);
    }
}
