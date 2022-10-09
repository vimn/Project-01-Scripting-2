using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamDamage : MonoBehaviour
{
    Player player;

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
        yield return new WaitForSeconds(3);
        player.TakeDamage(5);
    }
}
