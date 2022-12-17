using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_change : MonoBehaviour
{
    public GameObject Brightness_camera;
    public GameObject Fps;
    public GameObject start_mention;
    public GameObject Brightness_camera_mention;
    public GameObject MultiPass_camera;
    public GameObject MultiPass_mention;
    public GameObject Overlay_camera;
    public GameObject Overlay_mention;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Brightness_camera.SetActive(false);
                Fps.SetActive(true);
            start_mention.SetActive(true);
            Brightness_camera_mention.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Brightness_camera.SetActive(true);
            Brightness_camera_mention.SetActive(true);
            MultiPass_camera.SetActive(false);
            MultiPass_mention.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            MultiPass_camera.SetActive(true);
            MultiPass_mention.SetActive(true);
            Overlay_camera.SetActive(false);
            Overlay_mention.SetActive(false);
        }
    }
}
