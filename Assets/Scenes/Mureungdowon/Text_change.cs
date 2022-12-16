using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text_change : MonoBehaviour
{
    public GameObject change;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            change.SetActive(false);
        }
    }
}
