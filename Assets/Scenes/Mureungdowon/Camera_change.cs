using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_change : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Fps;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Camera.SetActive(false);
                Fps.SetActive(true);
        }
    }
}
