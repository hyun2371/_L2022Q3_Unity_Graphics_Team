using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat_move : MonoBehaviour
{
    public GameObject GameObject;

    //isTrigger�� üũ������ �� �Լ� �����
    private void OnTriggerEnter(Collider other)
    {
        GameObject.GetComponent<Animator>().SetInteger("State", 1);
    }
}
