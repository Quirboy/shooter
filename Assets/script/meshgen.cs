using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshCollider))]
public class meshgen : MonoBehaviour
{
    Mesh mesh;
    Vector3[] verticals;
    int[] triangles;

    // Start is called before the first frame update
    void Start()
    {

        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
   
        createshape();
        Updatemesh();
    }

    
    
    
        
 
    void createshape()
         
    {
        verticals = new Vector3[]
            {
            new Vector3(0.0f, 0.0f, 0.0f), //bottom left
            new Vector3(0.0f, 0.0f, 1.0f), // top left
            new Vector3(1.0f, 0.0f, 0.0f),
            new Vector3(1.0f, 0.0f, 1.0f),// bottom right
            new Vector3(1.0f, 0.0f, 1.0f),
            };

        triangles = new int[]
        {
           
             0, 1, 2, // Triangle 1 (apex, top-left, top-right)
            0, 2, 3, // Triangle 2 (apex, top-right, bottom-right)
            0, 3, 1, // Triangle 3 (apex, bottom-right, top-left)
            1, 2, 3,



        };
    }
    void Updatemesh()
    {
        mesh.Clear();

        mesh.vertices = verticals;
        mesh.triangles = triangles;
    }
}