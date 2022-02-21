using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset;
    [SerializeField] float camSpeed = 4f;

    int i = 1;
    void Start()
    {
        offset = transform.position - target.position;
        //RenderSettings.skybox = skyboxMat[0];
        //nextSkyboxtime = timediff;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        //transform.position = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, target.position + offset, camSpeed * Time.deltaTime);
    }

}

