using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class BoatArrive : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            transform.parent = null;
            transform.position = new Vector3(547, 31, 456);
            print("finished");
        }
    }
}
