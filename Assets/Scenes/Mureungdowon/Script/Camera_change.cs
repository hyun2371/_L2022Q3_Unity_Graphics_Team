using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_change : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Fps;
    public GameObject start_mention;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Camera.SetActive(false);
                Fps.SetActive(true);
            start_mention.SetActive(true);

        }
    }
}
