using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDamageable : MonoBehaviour
{
    public int _maxHealth;
    public int _currentHealth;
    public ParticleSystem deathParticles;
    [SerializeField] AudioClip _deathSound;
    public void DecreaseHealth(int amount)
    {
        _currentHealth -= amount;
        if (_currentHealth <= 0)
        {
            Kill();
        }
    }
    private void Awake()
    {
        _currentHealth = _maxHealth;
    }
    public void Kill()
    {
        if (deathParticles != null)
        {
            ParticleSystem deathFx = Instantiate(deathParticles, transform.position, transform.rotation);
        }
        if (_deathSound != null)
        {
            AudioHelper.PlayClip2D(_deathSound, 1f);
        }
        
        gameObject.SetActive(false);
    }
}
