using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelController : MonoBehaviour
{
    public Player player;
    public BossMovement boss;
    public TextMeshProUGUI bossHealth;
    public TextMeshProUGUI playerHealth;
    [SerializeField] AudioClip _music;
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
        bossHealth.text = "Boss health: " + boss._currentHealth.ToString() + " / " + boss._maxHealth.ToString();
        playerHealth.text = "Player health: " + player._currentHealth.ToString() + " / " + player._maxHealth.ToString();
    }
    private void Awake()
    {
        AudioHelper.PlayClip2D(_music, .2f);
    }
}
