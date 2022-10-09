using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public Player player;
    public GameObject tank;
    private Animator mAnimator;
    public ParticleSystem bombParticles;
    [SerializeField] AudioClip explosionSound;
    private bool isExploding;
    private bool exploded;
    int minimumDistance = 5;
    private void Start()
    {
        mAnimator = GetComponent<Animator>();
        tank = GameObject.Find("Tank");
        player = tank.GetComponent<Player>();
        isExploding = false;
        exploded = false;
    }
    private void Update()
    {
        if (exploded)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        mAnimator.SetTrigger("fuseStart");
        StartCoroutine(explode(3));
    }
    IEnumerator explode(float duration)
    {
        if (isExploding)
        {
            yield break;
        }
        isExploding = true;
        float counter = 0;

        while (counter < duration)
        {
            counter += Time.deltaTime;
            yield return null;
        }
        if(bombParticles != null)
        {
            ParticleSystem bombFx = Instantiate(bombParticles, transform.position, transform.rotation);
        }
        if(explosionSound != null)
        {
            AudioHelper.PlayClip2D(explosionSound, 1f);
        }

        if(Vector3.Distance(transform.position, player.transform.position) <= minimumDistance) 
        {
            Debug.Log("player was " + (transform.position - player.transform.position) + " close");
            player.TakeDamage(2);
        }
        
        exploded = true;
        
    }
}
