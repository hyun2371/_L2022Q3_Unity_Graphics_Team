using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invert_image : MonoBehaviour
{

    Shader myShader;        // image effect 셰이더  

    Material myMaterial;



    void Start()

    {

        // image effect shader 파일을 생성하고 

        // 셰이터의 경로와 파일을 아래와 같이 수정했어야 함 

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