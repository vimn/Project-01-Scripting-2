using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour, IDamageable
{
    public int _maxHealth = 3;
    public int _currentHealth;
    public bool invincible = false;
    public HealthBar healthBar;
    
    [SerializeField] GameObject loseScreen;
    [SerializeField] GameObject damageVin;
    [SerializeField] CameraShake camShake;

    TankController _tankController;
    // Start is called before the first frame update
    private void Awake()
    {

        _currentHealth = _maxHealth;
        healthBar.SetMaxHealth(_maxHealth);
    }

    public void IncreaseHealth(int amount) 
    {
        _currentHealth += amount;
        healthBar.SetHealth(_currentHealth);
    }

    public void Invincible() 
    {
        invincible = true;
    }
    public void unInvincible()
    {
        invincible = false;
    }

    public void TakeDamage(int amount)
    {
        _currentHealth -= amount;
        healthBar.SetHealth(_currentHealth);
        camShake.shakeDuration = .5f;
        StartCoroutine(Vignette(damageVin));
    }

    public void Kill()
    {
        Destroy(this.gameObject);
        loseScreen.SetActive(true);
    }
    IEnumerator Vignette(GameObject vin)
    {
        vin.SetActive(true);
        yield return new WaitForSeconds(.3f);
        vin.SetActive(false);
    }
}
