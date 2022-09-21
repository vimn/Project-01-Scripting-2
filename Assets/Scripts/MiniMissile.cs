using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMissile : Projectile
{
    [SerializeField] int _damage = 1;
    protected override void Impact(Collision target)
    {
        IDamageable damageableObject = target.gameObject.GetComponent<IDamageable>();
        if (damageableObject != null)
        {
            damageableObject.TakeDamage(_damage);
        }

    }

}
