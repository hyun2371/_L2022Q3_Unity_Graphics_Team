using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View_Bright : MonoBehaviour
{
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        camera.GetComponent<Brightness_Contrast_Saturation>().enabled = false;
    }
    void Update()
    {
        camera.GetComponent<Brightness_Contrast_Saturation>().enabled = true;
    }

}
