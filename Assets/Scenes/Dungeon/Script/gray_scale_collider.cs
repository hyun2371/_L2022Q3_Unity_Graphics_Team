using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gray_scale_collider : MonoBehaviour
{
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        camera.GetComponent<gray_scale>().enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        camera.GetComponent<gray_scale>().enabled = true;
    }
    // Update is called once per frame
    private void OnTriggerExit(Collider other)
    {
        camera.GetComponent<gray_scale>().enabled = false;
    }
}
