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

    TankController _tankController;
    // Start is called before the first frame update
    private void Awake()
    {
        _tankController = GetComponent<TankController>();
        _currentHealth = _maxHealth;
    }

    public void IncreaseHealth(int amount) 
    {
        _currentHealth += amount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth);
        Debug.Log("Player's health: " + _currentHealth);
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
        Debug.Log("Player damaged");
    }

    public void Kill()
    {
        Debug.Log("Player killed");
    }
}
