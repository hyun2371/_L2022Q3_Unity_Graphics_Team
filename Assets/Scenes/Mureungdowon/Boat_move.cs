using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat_move : MonoBehaviour
{
    public GameObject Pivot;

    //isTrigger에 체크했으면 이 함수 써야함
    private void OnTriggerEnter(Collider other)
    {
        //print("enter: " + other.name);
        Pivot.GetComponent<Animator>().SetInteger("State", 1);
    }
}
