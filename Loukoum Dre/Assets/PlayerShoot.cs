using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PlayerShoot : MonoBehaviour
{
    private Animator animator;
    public GameObject playerBullet;
    public Transform shootPoint;
    private bool canShoot = true;
    [Range(0, 2)]
    public float shootDelay = 0.3f;
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            if (canShoot) { animator.SetBool("IsFiring", true); StartCoroutine(Shoot()); }
        }
    }

    IEnumerator Shoot()
    {
        
        canShoot = false;
        Instantiate(playerBullet, shootPoint.position, Quaternion.identity);
        yield return new WaitForSeconds(shootDelay);
        canShoot = true;
    }
    private void FiringEnd()
    {
        animator.SetBool("IsFiring", false);
    }
}
