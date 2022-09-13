using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject explosion;
    private ParticleSystem ps;
    void OnTriggerEnter(Collider other)
    {
        ps = GetComponent<ParticleSystem>();
        Debug.Log("Hit: " + other);
        if(other.tag != "Player")
        {
            Instantiate(explosion, transform);
            Destroy(this.gameObject, ps.main.duration);
        }
        
    }
}
