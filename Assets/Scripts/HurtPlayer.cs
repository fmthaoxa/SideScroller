using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour {

   // private CircleCollider2D myCollider;

	// Use this for initialization
	void Start () {
       // myCollider = GetComponent<CircleCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D other) {

        if (other.gameObject.name == "Player") {
            Destroy(other.gameObject);
        }
    }
}
