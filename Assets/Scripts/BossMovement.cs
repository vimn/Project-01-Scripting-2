using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    int bossPhase;
    bool isMoving = false;
    IDamageable boss;
    [SerializeField] GameObject bossBody;
    [SerializeField] Vector3 nwPosition;
    [SerializeField] Vector3 nePosition;
    [SerializeField] Vector3 swPosition;
    [SerializeField] Vector3 sePosition;
    

    // Start is called before the first frame update
    public void MoveBoss(int move)
    {
        //StartCoroutine(dive(boss.transform, 1f));
        Debug.Log("random range chosen: " + move);

        if(move == 1) //north west
        {
            Debug.Log("Position north west");
            bossBody.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            bossBody.transform.position = nwPosition;
        }
        if (move == 2) //north east
        {
            Debug.Log("Position north east");
            bossBody.transform.eulerAngles = new Vector3(0f, 90f, 0f);
            bossBody.transform.position = nePosition;
        }
        if (move == 3) //south west
        {
            Debug.Log("Position south west");
            bossBody.transform.eulerAngles = new Vector3(0f, 270f, 0f);
            bossBody.transform.position = swPosition;
        }
        if (move == 4) //south east
        {
            Debug.Log("Position south east");
            bossBody.transform.eulerAngles = new Vector3(0f, 180f, 0f);
            bossBody.transform.position = sePosition;
           
        }
        
    }
    private void Update()
    {
        if(boss._currentHealth < 20 && (bossPhase == 1))
        {
            int randMove = Random.Range(1, 5);
            MoveBoss(randMove);
            bossPhase = 2;
        }
        if (boss._currentHealth < 15 && (bossPhase == 2))
        {
            int randMove = Random.Range(1, 5);
            MoveBoss(randMove);
            bossPhase = 3;
        }
        if (boss._currentHealth < 5 && (bossPhase == 3))
        {
            int randMove = Random.Range(1, 5);
            MoveBoss(randMove);
            bossPhase = 4;
        }
        

    }
    private void Start()
    {
        bossPhase = 1;
        boss = this.gameObject.GetComponent<IDamageable>();
    }

    IEnumerator dive(Transform fromPosition, float duration)
    {
        //Make sure there is only one instance of this function running
        if (isMoving)
        {
            yield break; ///exit if this is still running
        }
        isMoving = true;

        float counter = 0;

        //Get the current position of the object to be moved
        Vector3 startPos = fromPosition.position;
        Vector3 endPos = fromPosition.position -= new Vector3(0f, 10f, 0f);
        //Vector3 toPosition = (0f, dropDistance, 0f);

        while (counter < duration)
        {
            counter += Time.deltaTime;
            fromPosition.position = Vector3.Lerp(startPos, endPos, counter / duration);
            
            yield return null;
        }

        isMoving = false;
    }
    
}
