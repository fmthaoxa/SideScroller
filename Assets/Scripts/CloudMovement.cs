﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{

   

    public float speed;
    public float endx;
    public float startx;


    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= endx)

        {
              
            Vector2 pos = new Vector2(startx, transform.position.y);
            transform.position = pos;
        }
    }
}
