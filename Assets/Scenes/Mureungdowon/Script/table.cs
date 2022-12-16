using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class table : MonoBehaviour
{
    Vector3 V0, V1, V2, V3, V4, V5, V6, V7;

    Vector3[] newVertices;

    int[] newTriangles;

    public Vector2 UV0, UV1, UV2, UV3, UV4, UV5, UV6, UV7;
    Vector2[] newUVs;

    public Texture newTexture;
    
    void Start()

    {

        V0 = new Vector3(-0.5f, -0.5f, -0.5f);

        V1 = new Vector3(-0.5f, -0.5f, 0.5f);

        V2 = new Vector3(0.5f, -0.5f, 0.5f);

        V3 = new Vector3(0.5f, -0.5f, -0.5f);

        V4 = new Vector3(-0.4f, 0.4f, -0.4f);

        V5 = new Vector3(-0.4f, 0.4f, 0.4f);

        V6 = new Vector3(0.4f, 0.4f, 0.4f);

        V7 = new Vector3(0.4f, 0.4f, -0.4f);



        newVertices = new Vector3[]

        {

            V0, V1, V2, V3, V4, V5, V6, V7

        };



        newTriangles = new int[]

        { 

            // Back 

            0, 4, 7,

            0, 7, 3, 

 

            // Left 

            3, 7, 2,

            2, 7, 6, 

 

            // Front 

            1, 6, 5,

            1, 2, 6, 

 

            // Right 

            1, 4, 0,

            1, 5, 4, 

 

            // Top 

            4, 5, 6,

            4, 6, 7, 

 

            // Bottom 

            1, 0, 3,

            1, 3, 2

        };
        
        UV0 = new Vector2(0, 0);
        UV1 = new Vector2(0, 1);
        UV2 = new Vector2(1, 1);
        UV3 = new Vector2(1, 0);
        UV4 = new Vector2(0, 0);
        UV5 = new Vector2(0, 1);
        UV6 = new Vector2(1, 1);
        UV7 = new Vector2(1, 0);
        newUVs = new Vector2[]
        {
            UV0, UV1, UV2, UV3, UV4, UV5, UV6, UV7
        };
        gameObject.AddComponent<MeshFilter>();

        gameObject.AddComponent<MeshRenderer>();



        Mesh mesh = new Mesh();

        GetComponent<MeshFilter>().mesh = mesh;

        mesh.vertices = newVertices;

        mesh.triangles = newTriangles;

        mesh.uv = newUVs;



        Shader DefaultShader = Shader.Find("Standard");

        Material DefaultMaterial = new Material(DefaultShader);
        DefaultMaterial.mainTexture = newTexture;

        gameObject.GetComponent<Renderer>().material = DefaultMaterial;
    }
}
