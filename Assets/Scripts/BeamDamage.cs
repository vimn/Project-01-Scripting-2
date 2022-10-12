using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamDamage : MonoBehaviour
{
    Player player;
    [SerializeField] BossMovement boss;

    private void OnTriggerEnter(Collider other)
    {

        player = other.gameObject.GetComponent<Player>();
        if (player != null)
        {

            StartCoroutine(beamDmg(5));

        }

    }

    IEnumerator beamDmg(float damage)
    {
        yield return new WaitForSeconds(1);
        if (!boss.isMoving)
        {
            player.TakeDamage(1);
        }
        
    }
}
