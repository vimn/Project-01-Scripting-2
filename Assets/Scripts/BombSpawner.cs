using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    private bool spawning;
    [SerializeField] BossMovement boss;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject spawn4;
    public GameObject spawn5;
    public GameObject spawn6;
    public GameObject spawn7;
    public GameObject spawn8;
    public GameObject spawn9;
    public GameObject bomb;
    public float spawnSpeed;
    private void Update()
    {
        if (boss != null && boss._currentHealth >= 1)
        {
            StartCoroutine(spawn(spawnSpeed));
        }
    }
    private void Awake()
    {
        spawning = false;
    }
    private void BombSpawnPosition1()
    {
        Instantiate(bomb, spawn1.transform.position, spawn1.transform.rotation);
    }
    private void BombSpawnPosition2()
    {
        Instantiate(bomb, spawn2.transform.position, spawn2.transform.rotation);
    }
    private void BombSpawnPosition3()
    {
        Instantiate(bomb, spawn3.transform.position, spawn3.transform.rotation);
    }
    private void BombSpawnPosition4()
    {
        Instantiate(bomb, spawn4.transform.position, spawn4.transform.rotation);
    }
    private void BombSpawnPosition5()
    {
        Instantiate(bomb, spawn5.transform.position, spawn5.transform.rotation);
    }
    private void BombSpawnPosition6()
    {
        Instantiate(bomb, spawn6.transform.position, spawn6.transform.rotation);
    }
    private void BombSpawnPosition7()
    {
        Instantiate(bomb, spawn7.transform.position, spawn7.transform.rotation);
    }
    private void BombSpawnPosition8()
    {
        Instantiate(bomb, spawn8.transform.position, spawn8.transform.rotation);
    }
    private void BombSpawnPosition9()
    {
        Instantiate(bomb, spawn9.transform.position, spawn9.transform.rotation);
    }
    IEnumerator spawn(float duration)
    {
        if (spawning)
        {
            yield break;
        }
        //float counter = 0;
        spawning = true;
        
        int randSpawn = Random.Range(1, 5);

        if((randSpawn == 1) && (boss.bossPhase == 1))
        {
            BombSpawnPosition4();
            BombSpawnPosition6();

        }
        if ((randSpawn == 2) && (boss.bossPhase == 1))
        {
            BombSpawnPosition2();
            BombSpawnPosition8();


        }
        if ((randSpawn == 3) && (boss.bossPhase == 1))
        {

            BombSpawnPosition1();
            BombSpawnPosition9();

        }
        if ((randSpawn == 4) && (boss.bossPhase == 1))
        {

            BombSpawnPosition3();
            BombSpawnPosition7();
        }


        if ((randSpawn == 1) && (boss.bossPhase == 2))
        {
            BombSpawnPosition1();
            BombSpawnPosition5();
            BombSpawnPosition9();

        }
        if ((randSpawn == 2) && (boss.bossPhase == 2))
        {
            BombSpawnPosition4();
            BombSpawnPosition5();
            BombSpawnPosition6();
        }
        if ((randSpawn == 3) && (boss.bossPhase == 2))
        {
            BombSpawnPosition1();
            BombSpawnPosition2();
            BombSpawnPosition4();

        }
        if ((randSpawn == 4) && (boss.bossPhase == 2))
        {
            BombSpawnPosition6();
            BombSpawnPosition8();
            BombSpawnPosition9();

        }


        if ((randSpawn == 1) && (boss.bossPhase == 3))
        {
            BombSpawnPosition1();
            BombSpawnPosition2();
            BombSpawnPosition4();
            BombSpawnPosition6();
            BombSpawnPosition8();
            BombSpawnPosition9();

        }
        if ((randSpawn == 2) && (boss.bossPhase == 3))
        {
            BombSpawnPosition1();
            BombSpawnPosition3();
            BombSpawnPosition6();
            BombSpawnPosition4();
            BombSpawnPosition7();
            BombSpawnPosition9();

        }
        if ((randSpawn == 3) && (boss.bossPhase == 3))
        {
            BombSpawnPosition1();
            BombSpawnPosition3();
            BombSpawnPosition6();
            BombSpawnPosition2();
            BombSpawnPosition5();
            BombSpawnPosition8();

        }
        if ((randSpawn == 4) && (boss.bossPhase == 3))
        {
            BombSpawnPosition4();
            BombSpawnPosition7();
            BombSpawnPosition9();
            BombSpawnPosition2();
            BombSpawnPosition5();
            BombSpawnPosition8();

        }
        if ((randSpawn == 1) && (boss.bossPhase == 4))
        {
            BombSpawnPosition1();
            BombSpawnPosition2();
            BombSpawnPosition3();
            BombSpawnPosition4();
            BombSpawnPosition6();
            BombSpawnPosition8();
            BombSpawnPosition9();

        }
        if ((randSpawn == 2) && (boss.bossPhase == 4))
        {
            BombSpawnPosition1();
            BombSpawnPosition3();
            BombSpawnPosition6();
            BombSpawnPosition4();
            BombSpawnPosition7();
            BombSpawnPosition9();
            BombSpawnPosition8();

        }
        if ((randSpawn == 3) && (boss.bossPhase == 4))
        {
            BombSpawnPosition1();
            BombSpawnPosition3();
            BombSpawnPosition6();
            BombSpawnPosition4();
            BombSpawnPosition2();
            BombSpawnPosition5();
            BombSpawnPosition8();

        }
        if ((randSpawn == 4) && (boss.bossPhase == 4))
        {
            BombSpawnPosition1();
            BombSpawnPosition4();
            BombSpawnPosition7();
            BombSpawnPosition9();
            BombSpawnPosition2();
            BombSpawnPosition5();
            BombSpawnPosition8();

        }
        yield return new WaitForSeconds(duration);
        spawning = false;
    }

}
