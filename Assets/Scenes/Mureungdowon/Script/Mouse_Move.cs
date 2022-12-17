using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Move : MonoBehaviour
{
    Animator Anim;

    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.speed = 0;
    }

    void Update()
    {
    }

    private void OnMouseDown()
    {
        Anim.speed = 1;
    }
    private void OnMouseUp()
    {
        Anim.speed = 0;
    }

}
