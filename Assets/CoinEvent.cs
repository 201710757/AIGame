using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinEvent : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            GameObject.Find("Player").GetComponent<CharacterControls>().SCORE += 1;
            gameObject.SetActive(false);
        }
    }
}
