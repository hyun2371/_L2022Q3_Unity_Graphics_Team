using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invert_image : MonoBehaviour
{

    Shader myShader;        // image effect ���̴�  

    Material myMaterial;



    void Start()

    {

        // image effect shader ������ �����ϰ� 

        // �������� ��ο� ������ �Ʒ��� ���� �����߾�� �� 

        myShader = Shader.Find("My/PostEffects/invert_image");

        myMaterial = new Material(myShader);

    }



    private void OnDisable()

    {

        if (myMaterial)

        {

            DestroyImmediate(myMaterial);

        }

    }


    private void OnRenderImage(RenderTexture source, RenderTexture destination)

    {

        Graphics.Blit(source, destination, myMaterial, 0);

    }

}