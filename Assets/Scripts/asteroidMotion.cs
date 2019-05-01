using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidMotion : MonoBehaviour
{
    Vector3 dir;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 end = GameObject.Find("Earth").transform.position;
        dir = end - transform.position;
        dir.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + dir * speed;
        Vector3 ep = GameObject.Find("Earth").transform.position;
        Vector3 p = ep - transform.position;
    }
}
