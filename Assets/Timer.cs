using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public Text time;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        time = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        time.text = "TIME : " + GameObject.Find("Player").GetComponent<CharacterControls>().TIME;
    }
}
