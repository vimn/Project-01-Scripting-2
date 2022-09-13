using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject explosion;
    void OnTriggerEnter(Collider other)
    {
        Instantiate(explosion, other.transform);
        Debug.Log("Destroying: " + other);
        Destroy(other.gameObject);
    }
}
