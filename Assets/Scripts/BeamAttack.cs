using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamAttack : MonoBehaviour
{
    BossMovement boss;
    public float attackSpeed;
    private bool attacking;
   // private Animator mAnimator;
    public Animator beam1;
    public Animator beam2;
    public Animator beam3;
    [SerializeField] AudioClip beamSound;
    [SerializeField] AudioClip beamSound2;
    bool spdIncrease;
    // Start is called before the first frame update
    void Start()
    {
       boss = GetComponent<BossMovement>();
       attacking = false;
      // mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      if (boss != null)
        {
            StartCoroutine(beamAttack(attackSpeed, 4));

        }  
      if ((boss.bossPhase >= 3) && (!spdIncrease))
        {
            spdIncrease = true;
            attackSpeed -= 3;
        }

    }

    IEnumerator beamAttack(float duration, float beamTime)
    {
        if (boss.isMoving)
        {
            beam1.SetTrigger("TrReturn");
            beam2.SetTrigger("TrReturn");
            beam3.SetTrigger("TrReturn");
        }
        if (attacking || boss.isMoving)
        {
            yield break;
        }
        attacking = true;
        int randAttack = Random.Range(1, 4);

        if(randAttack == 1)
        {
            Debug.Log("beam1");
            beam1.SetTrigger("TrAttack");
            AudioHelper.PlayClip2D(beamSound, 1f);

        }
        if (randAttack == 2)
        {
            Debug.Log("beam2");
            beam2.SetTrigger("TrAttack");
            AudioHelper.PlayClip2D(beamSound, 1f);

        }
        if (randAttack == 3)
        {
            Debug.Log("beam3");
            beam3.SetTrigger("TrAttack");
            AudioHelper.PlayClip2D(beamSound, 1f);

        }
            
        AudioHelper.PlayClip2D(beamSound2, 1f);
        yield return new WaitForSeconds(beamTime);
        beam1.SetTrigger("TrReturn");
        beam2.SetTrigger("TrReturn");
        beam3.SetTrigger("TrReturn");

        yield return new WaitForSeconds(duration);
        attacking = false;

    }
}
