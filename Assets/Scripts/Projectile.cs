using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Transform myTransform;
    public int projectileSpeed = 7;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
       // myTransform.Translate(Vector3.Angle)
    }
}
