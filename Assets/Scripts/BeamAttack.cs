using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamAttack : MonoBehaviour
{
    BossMovement boss;
    public float attackSpeed;
    private bool attacking;
    // Start is called before the first frame update
    void Start()
    {
       boss = GetComponent<BossMovement>();
       attacking = false;
    }

    // Update is called once per frame
    void Update()
    {
      if (boss != null)
        {
            StartCoroutine(beamAttack(attackSpeed));

        }  
    }

    IEnumerator beamAttack(float duration)
    {
        if (attacking)
        {
            yield break;
        }

        int randAttack = Random.Range(1, 4);

        if(randAttack == 1)
        {

        }
        if (randAttack == 2)
        {

        }
        if (randAttack == 3)
        {

        }
    }
}
