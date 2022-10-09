using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour, IDamageable
{
    public int _maxHealth = 3;
    public int _currentHealth;
    public bool invincible = false;
    public TextMeshProUGUI txt;
    public HealthBar healthBar;

    TankController _tankController;
    // Start is called before the first frame update
    private void Awake()
    {
        _tankController = GetComponent<TankController>();
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
    }

    public void Kill()
    {
        Debug.Log("Player killed");
    }
}
