using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat_move : MonoBehaviour
{
    public GameObject GameObject;

    //isTrigger에 체크했으면 이 함수 써야함
    private void OnTriggerEnter(Collider other)
    {
        GameObject.GetComponent<Animator>().SetInteger("State", 1);
    }
}
