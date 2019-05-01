using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    public float s = 2000f;
    public float time = 0f;
    public GameObject scoreboard;
    bool active = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time >= 60f)
        {
            if(active)
            {
                active = false;
                GameObject b = GameObject.Find("bullets");
                Destroy(b);
                scoreboard.SetActive(true);
                GameObject.Find("scoretext").GetComponent<showscore>().updatescore();
            }
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        s = s - 10;
    }
}
