using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform gunHolder;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float bulletSpeed=1200f;
    [SerializeField] Transform shootPoint;
    Vector2 direction;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePos - (Vector2)gunHolder.position;
        GunRotation();
        if(Input.GetMouseButtonDown(0))
        {
            SloMotion.instance.doslomo = false;
            Debug.Log("called");
            ShootBullet();
            
        }
    }
   void GunRotation()
    {
        gunHolder.transform.right = direction;
    }
    void ShootBullet()
    {
        GameObject g = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
        //g.GetComponent<Rigidbody2D>().AddForce(g.transform.right * bulletSpeed);
        Destroy(g, 3f);
        /// velocity wala
        /// 
    }


}
