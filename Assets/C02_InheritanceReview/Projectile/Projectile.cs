using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//namespace Inheritance

public abstract class Projectile : MonoBehaviour
{
    protected abstract void Impact(Collision boss);

        [Header("Base Settings")]
        [SerializeField] protected float TravelSpeed = .25f;
        [SerializeField] protected Rigidbody RB;
        [SerializeField] ParticleSystem _impactParticles;
        [SerializeField] AudioClip _impactSound;

    private void OnCollisionEnter(Collision other)
    {
           // Debug.Log("Projectile collision!");
            Feedback();
            Impact(other);
        //gameObject.SetActive(false);
            Destroy(this.gameObject);
    }

        private void FixedUpdate()
        {
            Move();
        }

        protected virtual void Move()
        {
            Vector3 moveOffset = transform.forward * TravelSpeed;
            RB.MovePosition(RB.position + moveOffset);
        }
        private void Feedback()
        {
            if(_impactParticles != null)
            {
                _impactParticles = Instantiate(_impactParticles, transform.position, Quaternion.identity);
            }
            if (_impactSound != null)
            {
                AudioHelper.PlayClip2D(_impactSound, 1f);
            }
        }

}


