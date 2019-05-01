using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showscore : MonoBehaviour
{
    Text scoretext;
    float score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void updatescore()
    {
        scoretext = GetComponent<Text>();
        score = GameObject.Find("Earth").GetComponent<score>().s;
        scoretext.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
