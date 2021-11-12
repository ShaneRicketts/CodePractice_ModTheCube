using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float rotationSpeed;
    private float time = 0.0f;
    public float cooldown = 1f;
    
    void Start()
    {
        ChangeCubeValues();
    }

    void Update()
    {
        transform.Rotate(rotationSpeed, rotationSpeed, rotationSpeed);
        
        time += Time.deltaTime;
        if (time >= cooldown)
        {
            time = time - cooldown;
            ChangeCubeValues();
        }
    }

    void ChangeCubeValues()
    {
        rotationSpeed = Random.Range(-50, 50) * Time.deltaTime;
        transform.position = Vector3.zero + new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));
        transform.localScale = new Vector3(Random.Range(1, 5), Random.Range(1, 5), Random.Range(1, 5));
        Material material = Renderer.material;
        material.color = Random.ColorHSV(0, 1, 0, 1, 0, 1, 0, 1);
    }

}
