using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    int bossPhase;
    Boss boss;
    // Start is called before the first frame update
    public void MoveBoss()
    {
        int randMove = Random.Range(1, 5);
        Debug.Log("random range chosen: " + randMove);
    }
    private void Update()
    {
        if(boss._currentHealth < 20 && (bossPhase == 1))
        {
            MoveBoss();
            bossPhase = 2;
        }
        
    }
    private void Start()
    {
        bossPhase = 1;
        boss = this.gameObject.GetComponent<Boss>();
    }
}
