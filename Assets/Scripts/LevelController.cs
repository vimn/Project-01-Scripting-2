using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelController : MonoBehaviour
{
    public Player player;
    public BossMovement boss;
    [SerializeField] AudioClip _music;
    [SerializeField] AudioClip _realMusic;
    public GameObject originalSound;
    bool music2;
    void Update()
    {
        if(boss.bossPhase == 3 && !music2)
        {
            originalSound = GameObject.Find("Audio2D");
            Destroy(originalSound);
            AudioHelper.PlayClip2D(_realMusic, .2f);
            music2 = true;
        }
        if (Input.GetKeyDown("backspace"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }
    private void Awake()
    {
        music2 = false;
        AudioHelper.PlayClip2D(_music, .2f);
    }
}
