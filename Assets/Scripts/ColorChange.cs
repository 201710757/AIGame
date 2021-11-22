using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private bool obastacle = false;
    Renderer capsuleColor;
    Color original;
    float timer = 0.0f;

    void Start()
    {
        original = capsuleColor.material.color;
        capsuleColor = gameObject.GetComponent<Renderer>();
    }


    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1)
            capsuleColor.material.color = original;

        if (obastacle)
        {
            timer = 0.0f;
            obastacle = false;
            capsuleColor.material.color = Color.red;
            
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("obstacle"))
        {
            obastacle = true;
        }
    }
}
