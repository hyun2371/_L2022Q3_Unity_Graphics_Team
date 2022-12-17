using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invert_image : MonoBehaviour
{

    Shader myShader;        // image effect ºŒ¿Ã¥ı  

    Material myMaterial;
    void Start()
    {
        myShader = Shader.Find("My/PostEffects/invert_image");
        myMaterial = new Material(myShader);
    }


    private void OnRenderImage(RenderTexture source, RenderTexture destination)

    {

        Graphics.Blit(source, destination, myMaterial, 0);

    }

}