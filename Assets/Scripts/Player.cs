using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int _maxHealth = 3;
    int _currentHealth;
    public bool invincible = false;

    TankController _tankController;
    // Start is called before the first frame update
    private void Awake()
    {
        _tankController = GetComponent<TankController>();
    }

    private void Start()
    {
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
    public void DecreaseHealth(int amount) 
    {
        if (!invincible)
        {
            _currentHealth -= amount;
        }
        Debug.Log("Player's health: " + _currentHealth);
        if (_currentHealth <= 0) 
        {
            Kill();
        }
    }

    public void Kill() 
    {
        if (!invincible) 
        {
            gameObject.SetActive(false);
        }
        
    }
    private void Update()
    {
       // Debug.Log(invincible);
    }
}
