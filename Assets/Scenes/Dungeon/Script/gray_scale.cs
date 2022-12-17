using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class gray_scale : MonoBehaviour
{
    Shader myShader_1;        // image effect shader 
    Material myMaterial_1;

    public float grayScaleAmount = 1.0f;

    void Start()
    {
        myShader_1 = Shader.Find("My/PostEffects/gray_scale");    // image effect shader file must have been created
        myMaterial_1 = new Material(myShader_1);
    }

    private void Update()
    {
        grayScaleAmount = Mathf.Clamp(grayScaleAmount, 0.0f, 1.0f);
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        myMaterial_1.SetFloat("_GrayScaleAmount", grayScaleAmount);
        Graphics.Blit(source, destination, myMaterial_1);
    }
}

