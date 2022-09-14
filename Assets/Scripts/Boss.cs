using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Boss : MonoBehaviour
{
    [SerializeField] int _maxHealth = 3;
    public int _currentHealth;
    public TextMeshProUGUI txt;
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
    private void Update()
    {
        txt.text = "Boss health: " + _currentHealth.ToString();
    }

}
