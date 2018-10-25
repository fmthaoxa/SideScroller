using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour {

    public GameObject projectile;
    public float timeBetweenCounter;
    public float timeBetween;

	// Use this for initialization
	void Start () {
        timeBetweenCounter = timeBetween;
	}
	
	// Update is called once per frame
	void Update () {
        if (timeBetweenCounter <= 0) {
            Instantiate(projectile,transform.position, transform.rotation);
            timeBetweenCounter = timeBetween;
        }
        timeBetweenCounter -= Time.deltaTime;
	}
}


