using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : Projectile
{
    [SerializeField] int _damage = 1;
    [SerializeField] GameObject barrelL;
    [SerializeField] GameObject barrelR;
    [SerializeField] GameObject barrelC;
    [SerializeField] GameObject projectile;
    [SerializeField] ParticleSystem _launchParticles;
    [SerializeField] AudioClip _launchSound;

    private IEnumerator coroutine;
    Boss boss;
    protected override void Impact(Collision target)
    {
        boss = target.gameObject.GetComponent<Boss>();
        if(boss != null)
        {
            boss.DecreaseHealth(_damage);
        }
        
        
    }
    private void Start()
    {
        if (_launchParticles != null)
        {
            _launchParticles = Instantiate(_launchParticles, transform.position, Quaternion.identity);
        }
        if (_launchSound != null)
        {
            AudioHelper.PlayClip2D(_launchSound, 1f);
        }
       // Debug.Log("I have started");
        coroutine = WaitAndFire(1.0f);
        StartCoroutine(coroutine);
    }

    private IEnumerator WaitAndFire(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            GameObject mini1 = Instantiate(projectile, barrelL.transform.position, barrelL.transform.rotation);
            GameObject mini2 = Instantiate(projectile, barrelR.transform.position, barrelR.transform.rotation);
            GameObject mini3 = Instantiate(projectile, barrelC.transform.position, barrelC.transform.rotation);
            Destroy(this.gameObject);
        }
    }

}
