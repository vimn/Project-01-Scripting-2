using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] int _maxHealth = 3;
    int _currentHealth;
    public bool invincible = false;
    public TextMeshProUGUI txt;

    TankController _tankController;
    IDamageable damageable;
    // Start is called before the first frame update
    private void Awake()
    {
        _tankController = GetComponent<TankController>();
        damageable = GetComponent<IDamageable>();
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


}
