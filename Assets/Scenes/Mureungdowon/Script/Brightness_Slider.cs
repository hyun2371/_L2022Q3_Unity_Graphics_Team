using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brightness_Slider : MonoBehaviour
{
    public GameObject MyGameObject;
    Material MyMaterial;

    void Start()
    {
        MyMaterial = MyGameObject.GetComponent<Renderer>().material;
    }

    public void OnValueChanged()
    {
        float val = GetComponent<Slider>().value;
        MyMaterial.SetFloat("_Brigtness",val);
    }
}
