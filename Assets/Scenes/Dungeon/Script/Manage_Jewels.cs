using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manage_Jewels : MonoBehaviour
{
    public GameObject j1,j2,j3,j4;
    public bool IsJ1Active = false;
    public bool IsJ2Active = false;
    public bool IsJ3Active = false;
    public bool IsJ4Active = false;

    void Update()
    {
        if (IsJ1Active)
        {
            if (j1!=null)
                j1.SetActive(true);
        }
        if (IsJ2Active)
        {
            if (j2 != null)
                j2.SetActive(true);
        }
        if (IsJ3Active)
        {
            if (j3 != null)
                j3.SetActive(true);
        }
        if (IsJ4Active)
        {
            if (j4 != null)
                j4.SetActive(true);
        }
    }
}
