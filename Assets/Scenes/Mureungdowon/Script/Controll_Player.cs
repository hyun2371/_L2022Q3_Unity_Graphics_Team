using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class Controll_Player : MonoBehaviour
{
    public GameObject boat;
    private bool isRide = false;

    private void Update()
    {
        if (isRide)
        {
            transform.position =new Vector3(boat.transform.position.x - 1, boat.transform.position.y + 1, boat.transform.position.z - 1);
            transform.rotation = new Quaternion(boat.transform.eulerAngles.x, boat.transform.eulerAngles.y, boat.transform.eulerAngles.z,1);
        }
        if (boat.GetComponent<Animator>().GetBool("isArrive"))
        {
            takeOff();
        }
    }

    private void takeOff()
    {
        isRide = false;
        transform.parent = null;
        print("finished");
        boat.GetComponent<Animator>().SetBool("isArrive", false);
        transform.position = new Vector3(559, 31, 486);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RideTrigger")
        {
            GameObject Parent = other.transform.parent.gameObject;
            transform.parent = Parent.transform;
            boat.GetComponent<Animator>().SetInteger("State", 1);
            isRide = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "RideTrigger")
        {
            transform.position = new Vector3(559, 31, 486);
            boat.GetComponent<Animator>().SetInteger("State", 0);
            Invoke("restartBoat", 10f);

        }
    }


    private void restartBoat()
    {
        boat.GetComponent<Animator>().SetBool("isRestart", true);
    }


}


