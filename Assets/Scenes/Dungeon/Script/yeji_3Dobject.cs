using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yeji_3Dobject : MonoBehaviour
{
    Vector3 V0, V1, V2, V3, V4, V5, V6, V7;
    Vector3[] newVertices;
    int[] newTriangles;
    Vector3[] newNormals;

    public float speed = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        V0 = new Vector3(-0.5f, -0.5f, -0.5f);
        V1 = new Vector3(-0.5f, -0.5f, 0.5f);
        V2 = new Vector3(0.5f, -0.5f, 0.5f);
        V3 = new Vector3(0.5f, -0.5f, -0.5f);
        V4 = new Vector3(-0.5f, 0.5f, -0.5f);
        V5 = new Vector3(-0.5f, 0.5f, 0.5f);
        V6 = new Vector3(0.5f, 0.5f, 0.5f);
        V7 = new Vector3(0.5f, 0.5f, -0.5f);

        newVertices = new Vector3[]
        {
            V0, V4, V7, V3, //0, 1, 2, 3
            
            V3, V7, V6, V2, //4, 5, 6, 7

            V2, V6, V5, V1, //8, 9, 10, 11

            V1, V5, V4, V0, //12, 13, 14, 15

            V4, V5, V6, V7, //16, 17, 18, 19

            V0, V1, V2, V3 //20, 21, 22, 23
        };

        newTriangles = new int[]
        {
            0, 1, 2,
            0, 2, 3,

            4, 5, 7,
            7, 5, 6,

            8, 9, 11,
            11, 9, 10,

            12, 13, 14,
            12, 14, 15,

            16, 17, 18,
            16, 18, 19,

            21, 20, 23,
            21, 23, 22
        };

        Vector3 Up = Vector3.up;
        Vector3 Down = Vector3.down;
        Vector3 Front = Vector3.forward;
        Vector3 Left = Vector3.left;
        Vector3 Right = Vector3.right;
        Vector3 Back = Vector3.back;

        newNormals = new Vector3[]
        {
            Back, Back, Back, Back,

            Right, Right, Right, Right,

            Front, Front, Front, Front,

            Left, Left, Left, Left,

            Up, Up, Up, Up,

            Down, Down, Down, Down
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

    private void Update()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        Vector3[] normals = mesh.normals;

        for (var i = 0; i < vertices.Length; i++)
        {
            vertices[i] += normals[i] * Mathf.Sin(Time.time) * speed;
        }

        mesh.vertices = vertices;
    }
}
