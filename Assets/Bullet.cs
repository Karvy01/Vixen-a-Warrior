using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]float speed=10f;
    [SerializeField] GameObject deatheffect;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "platform" || collision.tag == "enemy")
        {
            if (collision.tag == "enemy")
            {
                Instantiate(deatheffect, transform.position, Quaternion.identity);
                Destroy(collision.gameObject);
            Destroy(gameObject);
            }
        }
    }
}
