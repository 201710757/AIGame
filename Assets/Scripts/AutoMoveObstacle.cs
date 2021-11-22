using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoveObstacle : MonoBehaviour
{
    public float Speed;
    public float move = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Speed = Random.Range(15.0f, 30.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // 20 over = minus
        if (transform.position.x > 20.0f || transform.position.x < -20.0f)
            move *= -1;
        transform.position += new Vector3(move, 0, 0) * Time.deltaTime * Speed;
    }
}
