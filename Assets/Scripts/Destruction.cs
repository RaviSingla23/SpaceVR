using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    // Start is called before the first frame update
    public int hits = 3;
    public GameObject explosion;
    public GameObject expnosound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnParticleCollision(GameObject other)
    {
        hits--;

        if(hits<=0)
        {
            Instantiate(explosion,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if((!collision.collider.CompareTag("ast")))
        {
            Instantiate(expnosound, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
