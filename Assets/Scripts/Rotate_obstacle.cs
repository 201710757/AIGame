using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_obstacle : MonoBehaviour
{
    float rotSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        rotSpeed = Random.Range(100.0f, 200.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, rotSpeed * Time.deltaTime, 0));
    }
}
