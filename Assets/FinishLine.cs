using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;


public class FinishLine : MonoBehaviour
{
    float alpha = 1.0f;
    public GameObject player;

    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        // player = GameObject.FindGameObjectWithTag("Player");

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
        if (other.gameObject.tag.Equals("Player"))
        {
            GameObject.Find("Player").GetComponent<CharacterControls>().dic.Add(GameObject.Find("Player").GetComponent<CharacterControls>().TIME, (int)GameObject.Find("Player").GetComponent<CharacterControls>().SCORE);


            if (GameObject.Find("Player").GetComponent<CharacterControls>().dic.Count <= 1)
            {
                alpha = 1.2f;
            }
            else
            {
                float top_key = 0.0f;
                float top_value = 0.0f;

                foreach(var dictionary_s in GameObject.Find("Player").GetComponent<CharacterControls>().dic)
                {
                    top_key = float.Parse(dictionary_s.Key);
                    top_value = dictionary_s.Value;

                    break;
                }
                top_key /= float.Parse(GameObject.Find("Player").GetComponent<CharacterControls>().TIME);
                top_value = (float)GameObject.Find("Player").GetComponent<CharacterControls>().SCORE / top_value;

                alpha = top_value * top_key;
            }

            if (alpha > 2.0) alpha = 2.0f;  // maximum level
            else if (alpha < 0.3) alpha = 0.3f; // minimum level

            GameObject.FindGameObjectWithTag("obstacle").GetComponent<Rotator>().speed *= alpha; 
            GameObject.FindGameObjectWithTag("obstacle").GetComponent<Bounce>().stunTime *= alpha;
            GameObject.FindGameObjectWithTag("obstacle6").GetComponent<Rotator>().speed *= alpha;
            GameObject.FindGameObjectWithTag("obstacle6").GetComponent<Bounce>().stunTime *= alpha;

            GameObject.FindGameObjectWithTag("obstacle1").GetComponent<Pendulum>().speed *= alpha;
            GameObject.FindGameObjectWithTag("obstacle2").GetComponent<FallPlat>().fallTime /= alpha;
            GameObject.FindGameObjectWithTag("obstacle3").GetComponent<WallMovable>().speed *= alpha;

            GameObject.FindGameObjectWithTag("obstacle4").GetComponent<MovableObs>().speed *= alpha;
            GameObject.FindGameObjectWithTag("obstacle5").GetComponent<MovableObs>().speed *= alpha;


            GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterControls>().alpha = alpha;

            GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterControls>().Reset_Timer();
            GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterControls>().gotoStartPoint();

        }
    }
}
