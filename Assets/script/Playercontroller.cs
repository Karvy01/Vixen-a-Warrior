using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    [SerializeField] float speed=10f;

    Vector2 moveAmount;
    public GameObject congopanel;
 float moveInputX;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInputX = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space)&&Mathf.Abs(rb.velocity.y)<0.001f)
        {
            rb.AddForce(Vector2.up * 15f, ForceMode2D.Impulse);
        }
        if(Input.GetAxis("Horizontal")==0)
        {
            SloMotion.instance.doslomo = true;
        }
        else
        {
            SloMotion.instance.doslomo = false ;
        }
        //moveAmount = moveInput.normalized * speed;

    }
    private void FixedUpdate()
    { 
       
        rb.velocity = new Vector2(moveInputX*speed, rb.velocity.y);
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="home")
        {
            congopanel.SetActive(true);
        }
        if(collision.gameObject.tag=="enemybullet")
        {
           
            Destroy(gameObject);
        }
    }
}
