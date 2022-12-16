using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gahyun_3Dobject : MonoBehaviour
{
    Vector3 V0, V1, V2, V3, V4, V5;
    Vector3[] newVertices;
    int[] newTriangles;
    Vector3[] newNormals;
    // Start is called before the first frame update
    void Start()
    {

        V0 = new Vector3(-0.5f, 0, -0.5f);
        V1 = new Vector3(-0.5f, 0, 0.5f);
        V2 = new Vector3(0.5f, 0, 0.5f);
        V3 = new Vector3(0.5f, 0, -0.5f);
        V4 = new Vector3(0, 1, 0);
        V5 = new Vector3(0, -1, 0); //피라미드에서 해당 정점 추가하면 다이아몬드

        newVertices = new Vector3[]
        {
            V0, V4, V3,
            V3, V4, V2,
            V2, V4, V1,
            V1, V4, V0,
            V3, V5, V0,
            V2, V5, V3,
            V1, V5, V2,
            V0, V5, V1,
            V3, V5, V0
        };

        //배열값 설정
        newTriangles = new int[]
        {
                0, 1, 2, //top front
                3, 4, 5, //top right
                6, 7, 8, //top back
                9, 10, 11, //top left
                12, 13, 14, //bottom front
                15, 16, 17, //bottom right
                18, 19, 20, //bottom back
                21,22, 23, //bottom left
        };

        Vector3 topFront = Vector3.up + Vector3.forward;
        Vector3 topRight = Vector3.up + Vector3.right;
        Vector3 topBack = Vector3.up + Vector3.back;
        Vector3 topLeft = Vector3.up + Vector3.left;
        Vector3 bottomFront = Vector3.down + Vector3.forward;
        Vector3 bottomRight = Vector3.down + Vector3.right;
        Vector3 bottomBack = Vector3.down + Vector3.back;
        Vector3 bottomLeft = Vector3.down + Vector3.left;
        Vector3 bottom = Vector3.down;

        newNormals = new Vector3[]
        {
            topFront,topFront,topFront,
            topRight,topRight,topRight,
            topBack,topBack,topBack,
            topLeft,topLeft,topLeft,
            bottomFront,bottomFront,bottomFront,
            bottomRight,bottomRight,bottomRight,
            bottomBack,bottomBack,bottomBack,
            bottomLeft,bottomLeft,bottomLeft,
            bottom,bottom,bottom
        };

        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();

        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        mesh.vertices = newVertices;
        mesh.triangles = newTriangles;
        mesh.normals = newNormals;

        mesh.RecalculateBounds();
        mesh.Optimize();

        Shader DefaultShader = Shader.Find("Standard");
        Material DefaultMaterial = new Material(DefaultShader);
        gameObject.GetComponent<Renderer>().material = DefaultMaterial;

    }
}
