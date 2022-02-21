using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float FireRate = 1.0f;
    public float NextFire = 1.0f;
    public float timeToDisappear = 5;


    public Transform target;
    public float enemyAimSpeed = 5.0f;
    Quaternion newRotation;
    float orientTransform;
    float orientTarget;

    void Update()
    {
        orientTransform = transform.position.x;
        orientTarget = target.position.x;
        if (orientTransform > orientTarget)
        {
            newRotation = Quaternion.LookRotation(transform.position - target.position, -Vector3.up);
        }
        else
        {
            newRotation = Quaternion.LookRotation(transform.position - target.position, Vector3.up);
        }

        newRotation.x = 0.0f;
        newRotation.y = 0.0f;

        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * enemyAimSpeed);
        if (Vector2.Distance(transform.position, target.position) < 10f)
        {
            if (Time.time > NextFire)
            {
                NextFire = Time.time + FireRate;


                Shoot();

            }
        }

    }




    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}

