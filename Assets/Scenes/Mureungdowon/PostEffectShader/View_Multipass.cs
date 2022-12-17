using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View_Multipass : MonoBehaviour
{
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        camera.GetComponent<Multipass>().enabled = false;
    }
    void Update()
    {
        camera.GetComponent<Multipass>().enabled = true;
    }
}
