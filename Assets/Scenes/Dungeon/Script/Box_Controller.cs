using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Controller : MonoBehaviour
{
    public GameObject Pivot;
    public GameObject panel;
    bool isOn;
    // Start is called before the first frame update
    void Start()
    {
        isOn = false;
        //panel.SetActive(isOn);
    }
    private void OnTriggerEnter(Collider other)
    {
        isOn = !isOn;
        //panel.SetActive(isOn);
        Pivot.GetComponent<Animator>().SetInteger("INT", 1);
        
    }
    private void OnTriggerExit(Collider other)
    {
        Pivot.GetComponent<Animator>().SetInteger("INT", 2);
        
    }
    private void Update()
    {
        if (Pivot.GetComponent<Animator>().GetBool("isOpened"))
        {
            panel.SetActive(true);
        }
        else
        {
            panel.SetActive(false);
        }
    }
}
