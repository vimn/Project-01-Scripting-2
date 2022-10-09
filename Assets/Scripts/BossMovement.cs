using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour, IDamageable
{
    public int bossPhase;
    bool isMoving = false;
    [SerializeField] GameObject bossBody;
    [SerializeField] Vector3 nwPosition;
    [SerializeField] Vector3 nePosition;
    [SerializeField] Vector3 swPosition;
    [SerializeField] Vector3 sePosition;
    public int _maxHealth;
    public int _currentHealth;
    public ParticleSystem deathParticles;
    [SerializeField] AudioClip _deathSound;
    [SerializeField] MeshRenderer _bossHealth;
    public HealthBar healthBar;


    // Start is called before the first frame update
    public void MoveBoss(int move)
    {
        
        Debug.Log("random range chosen: " + move);

            if (move == 1) //north west
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
               // StartCoroutine(rise(bossBody.transform, 1f));
            }
        //StartCoroutine(rise(bossBody.transform, 1f));

    }
    private void Update()
    {
        if(_currentHealth < 25 && (bossPhase == 1))
        {
            //int randMove = Random.Range(1, 5);
            StartCoroutine(dive(bossBody.transform, 1f));
            //MoveBoss(randMove);
            _bossHealth.material.color = Color.cyan;
            bossPhase = 2;
        }
        if (_currentHealth < 15 && (bossPhase == 2))
        {
            //int randMove = Random.Range(1, 5);
            //MoveBoss(randMove);
            StartCoroutine(dive(bossBody.transform, 1f));
            _bossHealth.material.color = Color.yellow;
            bossPhase = 3;
        }
        if (_currentHealth < 5 && (bossPhase == 3))
        {
            // int randMove = Random.Range(1, 5);
            // MoveBoss(randMove);
            StartCoroutine(dive(bossBody.transform, 1f));
            _bossHealth.material.color = Color.red;
            bossPhase = 4;
        }
        

    }
    private void Start()
    {
        bossPhase = 1;
        
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

        while (counter < duration)
        {
            counter += Time.deltaTime;
            fromPosition.position = Vector3.Lerp(startPos, endPos, counter / duration);
            
            yield return null;
        }
        int randMove = Random.Range(1, 5);
        MoveBoss(randMove);
        isMoving = false;
        StartCoroutine(rise(bossBody.transform, 1f));
    }
    IEnumerator rise(Transform fromPosition, float duration)
    {
        Debug.Log("rise called, moving is: " + isMoving);
       
        //Make sure there is only one instance of this function running
        if (isMoving)
        {
            yield break; ///exit if this is still running
        }
        isMoving = true;

        float counter = 0;

        //Get the current position of the object to be moved
        Vector3 startPos = fromPosition.position;
        Vector3 endPos = fromPosition.position += new Vector3(0f, 10f, 0f);

        while (counter < duration)
        {
            counter += Time.deltaTime;
            fromPosition.position = Vector3.Lerp(startPos, endPos, counter / duration);

            yield return null;
        }

        isMoving = false;
    }
    private void Awake()
    {
        _currentHealth = _maxHealth;
        healthBar.SetMaxHealth(_maxHealth);

    }
    public void TakeDamage(int amount)
    {
        _currentHealth -= amount;
        healthBar.SetHealth(_currentHealth);
        if (_currentHealth <= 0)
        {
            Kill();
        }
    }

    public void Kill()
    {
        if (deathParticles != null)
        {
            ParticleSystem deathFx = Instantiate(deathParticles, transform.position, transform.rotation);
        }
        if (_deathSound != null)
        {
            AudioHelper.PlayClip2D(_deathSound, 1f);
        }

        gameObject.SetActive(false);
    }
}
