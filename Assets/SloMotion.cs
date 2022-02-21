using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SloMotion : MonoBehaviour
{
    // Start is called before the first frame update
    float SlomoTime = 0.2f;
    float normaltime = 1f;
    public bool doslomo = false;
    [SerializeField] Rigidbody2D player;
    public static SloMotion instance;
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (!doslomo)
        {
            Time.timeScale = normaltime;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
           
        }


        if (doslomo)
        {
            Time.timeScale = SlomoTime;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
           
        }


    }
}
