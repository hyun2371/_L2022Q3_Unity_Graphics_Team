using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll_Player : MonoBehaviour
{
    public GameObject gameObject;
   

    //// Start is called before the first frame update
    //void Start()
    //{
    //    target = null;
    //}

    //// Update is called once per frame
    //void LateUpdate()
    //{
    //    if (target != null)
    //    {
    //        target.transform.position = transform.position + offset;
    //        target.transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z));
    //    }
    //}


    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "RideTrigger")
    //    {

    //        boat.GetComponent<Animator>().SetInteger("State", 1);
    //        target = other.gameObject;
    //        offset = target.transform.position - transform.position;
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RideTrigger")
        {
            GameObject Parent = other.transform.parent.gameObject;
            transform.parent = Parent.transform;
            gameObject.GetComponent<Animator>().SetInteger("State", 1);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        transform.parent = null;
    }
}


