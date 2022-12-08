using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startbutton_script : MonoBehaviour
{
    public Transform PosReference;
    private Camera TargetCamera;

    public float offsetX = 0;
    public float offsetY = 0;
    public float offsetZ = 0;
    // Start is called before the first frame update
    void Start()
    {
        //TargetCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        TargetCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 screenPos = TargetCamera.WorldToScreenPoint(new Vector3(PosReference.position.x + offsetX, PosReference.position.y + offsetY
            , PosReference.position.z + offsetZ));
        transform.position = new Vector3(screenPos.x, screenPos.y, transform.position.z);
        //DisplayAtPoint();
    }
    void DisplayAtPoint()
    {
        //Vector3 WorldPos = PosReference.position + Vector3.up;
        // ScreenPos = TargetCamera.WorldToScreenPoint(WorldPos);
        //transform.position = ScreenPos;
    }
}
