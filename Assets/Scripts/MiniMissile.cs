using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMissile : Projectile
{
    [SerializeField] int _damage = 1;

    IDamageable boss;
    protected override void Impact(Collision target)
    {
        boss = target.gameObject.GetComponent<IDamageable>();
        if (boss != null)
        {
            boss.DecreaseHealth(_damage);
        }


    }

}
