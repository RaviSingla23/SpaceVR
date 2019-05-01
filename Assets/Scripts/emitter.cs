using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emitter : MonoBehaviour
{
    // Start is called before the first frame update
    
    float g = 20f;
    public GameObject[] asteroids;
    public float delay = 1f;
    float t;
    void Start()
    {
        t = delay;
    }

    // Update is called once per frame
    void Update()
    {
        t = t + Time.deltaTime;
        if(t>=delay)
        {
            createAsteroids();
            t = 0f;
        }
    }

    void createAsteroids()
    {
        foreach(GameObject asteroid in asteroids)
        {
            Vector3 pos = new Vector3(transform.position.x + Random.Range(-g,g), transform.position.y + Random.Range(-g, g), transform.position.z + Random.Range(-g, g));
            Instantiate(asteroid, pos, Quaternion.identity);
        }
    }
}
