﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float topBound = 6.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * (speed * Time.deltaTime));
        if (transform.position.y > topBound)
        {
            Destroy(this.gameObject);
        }
    }
}
