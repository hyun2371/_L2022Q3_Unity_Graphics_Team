using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class table : MonoBehaviour
{
    Vector3 V0, V1, V2, V3, V4, V5, V6, V7;

    Vector3[] newVertices;

    int[] newTriangles;

    Vector3[] newNormals;

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

        gameObject.AddComponent<MeshFilter>();

        gameObject.AddComponent<MeshRenderer>();



        Mesh mesh = new Mesh();

        GetComponent<MeshFilter>().mesh = mesh;

        mesh.vertices = newVertices;

        mesh.triangles = newTriangles;

        mesh.normals = newNormals;



        Shader DefaultShader = Shader.Find("Standard");

        Material DefaultMaterial = new Material(DefaultShader);

        gameObject.GetComponent<Renderer>().material = DefaultMaterial;
    }
}
