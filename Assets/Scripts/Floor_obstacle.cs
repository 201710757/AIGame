using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_obstacle : MonoBehaviour
{
    public GameObject obj;
    private bool isRemoved;
    private bool startFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        isRemoved = (Random.value > 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(startFlag)
        {
            obj.SetActive(false);
        }    
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            startFlag = true;
        }
    }
}
