using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    protected abstract void PowerUp(Player player, bool pState);
    protected abstract void PowerDown(Player player, bool pState);

    [SerializeField] float _powerupDuration = 1;
    [SerializeField] ParticleSystem _collectParticles;
    [SerializeField] AudioClip _collectSound;
    [SerializeField] bool state = false;
    Player box;
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.gameObject.GetComponent<Player>();
        box = player;
        if (player != null)
        {
            player.invincible = true;
            PowerUp(player, state);
            Feedback();

            StartCoroutine(powerD());


        }
    }

    private void Feedback()
    {
        if (_collectParticles != null)
        {
            _collectParticles = Instantiate(_collectParticles, transform.position, Quaternion.identity);
        }
        if (_collectSound != null)
        {
            AudioHelper.PlayClip2D(_collectSound, 1f);
        }
    }
    IEnumerator powerD()
    {
        
        yield return new WaitForSeconds(5f);
        box.invincible = false;
        gameObject.SetActive(false);
    }
}
