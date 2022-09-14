using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    [SerializeField] int _maxHealth = 3;
    public int _currentHealth;
    public void DecreaseHealth(int amount)
    {
        _currentHealth -= amount;

        Debug.Log("Boss' health: " + _currentHealth);
        if (_currentHealth <= 0)
        {
            Kill();
        }
    }
    private void Start()
    {
        _currentHealth = _maxHealth;
    }
    public void Kill()
    {
        gameObject.SetActive(false);
    }

}
