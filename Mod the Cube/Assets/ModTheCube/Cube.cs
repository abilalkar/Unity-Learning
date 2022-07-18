using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float a, b, c, d;
    private float size = 1.0f;
    
    void Start()
    {
        transform.position = new Vector3(0,0,0);

        InvokeRepeating("LLateUpdate", 0, 1.0f);
        InvokeRepeating("ChangeSize", 0, 0.01f);


    }

    void Update()
    {
        transform.localScale = Vector3.one * size;

        a = Random.Range(0, 1);
        b = Random.Range(0, 1);
        c = Random.Range(0, 1);
        d = Random.Range(0, 1);


        transform.Rotate(50.0f * Time.deltaTime, 20.0f * Time.deltaTime, 0.0f);
    }

    void LLateUpdate()
    {
        Material material = Renderer.material;

        material.color = new Color(a, b, c, d);
    }

    void ChangeSize()
    {
        size += 0.01f;
    }
}
