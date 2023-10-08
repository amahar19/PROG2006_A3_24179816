using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScroll : MonoBehaviour
{
    
    public float speed = 2f;
    private Vector3 StartPosition;

    void Start()
    {
        StartPosition = transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);  
        if(transform.position.y < -2000f)
        {
            transform.position = StartPosition;
        }
    }
}
