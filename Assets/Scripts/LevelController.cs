using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelController : MonoBehaviour
{
    public IDamageable player;
    public IDamageable boss;
    public TextMeshProUGUI bossHealth;
    public TextMeshProUGUI playerHealth;
    void Update()
    {
        if (Input.GetKeyDown("backspace"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
        bossHealth.text = "Boss health: " + boss._currentHealth.ToString();
        playerHealth.text = "Player health: " + player._currentHealth.ToString();
    }
}
