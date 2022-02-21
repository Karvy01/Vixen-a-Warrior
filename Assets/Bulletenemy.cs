using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletenemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]float speed=10f;
    [SerializeField] GameObject Deatheffect;
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
        
        if (collision.tag == "player")
        {
            // Destroy(collision.gameObject);
          
            Instantiate(Deatheffect, transform.position, Quaternion.identity);
            collision.gameObject.SetActive(false);
            UiManager.instance.StartCoroutine("GameOverPanel");
            Destroy(gameObject);
          
        }
    }
    
}
