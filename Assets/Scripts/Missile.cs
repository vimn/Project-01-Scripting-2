using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : Projectile
{
    [SerializeField] int _damage = 1;

    Boss boss;
    protected override void Impact(Collider target)
    {
        boss = target.GetComponent<Boss>();
        if(boss != null)
        {
            boss.DecreaseHealth(_damage);
        }
        
        
    }

}
