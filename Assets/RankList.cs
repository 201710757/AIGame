using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System.Linq;
public class RankList : MonoBehaviour
{
    public Text rank;
    public string[] ran = { "1st", "2nd", "3rd" };
    // Start is called before the first frame update
    void Start()
    {
        rank = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        int r = 1;
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.AppendLine("Ranking System - order by Score");

        var dic = GameObject.Find("Player").GetComponent<CharacterControls>().dic.OrderByDescending(item => item.Value);//.OrderBy(item=>item.Key);
        foreach (var dictionary in dic)
        {
            if(r>3)
                sb.AppendLine((r).ToString() + "th Score : " + dictionary.Value + "  Time : " + dictionary.Key);
            else
                sb.AppendLine(ran[r - 1] + " Score : " + dictionary.Value + "  Time : " + dictionary.Key);
            rank.text = sb.ToString();

            r += 1;
        }
    }
}
