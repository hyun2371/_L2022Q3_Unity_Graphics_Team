using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invert_collider : MonoBehaviour
{
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        camera.GetComponent<invert_image>().enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        camera.GetComponent<invert_image>().enabled = true;
    }
    private void OnTriggerExit(Collider other)
    {
        camera.GetComponent<invert_image>().enabled = false;
    }
    // Update is called once per frame

}
