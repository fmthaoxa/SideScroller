using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour {

    // Use this for initialization
    public float speed;
    public float timeTillDestroy;
    public float timeTillDestroyCounter;


    // Use this for initialization
    void Start()
    {
        timeTillDestroyCounter = timeTillDestroy;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (timeTillDestroyCounter <= 0)
        {
            Destroy(gameObject);
        }
        timeTillDestroyCounter -= Time.deltaTime;
        
           
    }
}