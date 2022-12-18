using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windmill : MonoBehaviour
{
    Animator Anim;
    public bool isFirst = true;
    public GameObject key3;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.speed = 0.0f;
        Anim.SetFloat("Dir", 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            Anim.speed = 1.0f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Anim.speed = 0.0f;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Anim.speed = 2.0f;
            if (isFirst)
            {
                key3.SetActive(true);
                isFirst = false;
            }
        }
        if (Input.GetKey(KeyCode.F))
        {
            Anim.SetFloat("Dir", 1.0f);
        }
        if (Input.GetKey(KeyCode.B))
        {
            Anim.SetFloat("Dir", -1.0f);
        }
    }
}
