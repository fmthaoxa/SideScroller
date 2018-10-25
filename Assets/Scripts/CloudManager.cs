using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudManager : MonoBehaviour {

    public Transform setDeActivePiont;
    public Transform[] generatingCloudPoint;
    public Sprite[] clouds;
    public int num;
    public float spawnBetwenTime;
    public float spawnBetweenTimeCounter;


	// Use this for initialization
	void Start () {
    //    setDeActivePiont = GetComponent<Transform>();
     //   generatingCloudPoint = GetComponent<Transform[]>();
     //   clouds = GetComponent<Sprite[]>();
       // spawnBetweenTimeCounter = spawnBetwenTime;
	}
	
	// Update is called once per frame
	void Update () {
        /*
        if (spawnBetweenTimeCounter <= 0)
        {
            int random = Random.Range(0, num);

            if (generatingCloudPoint[random].gameObject.activeSelf)
            {
                generatingCloudPoint[random].gameObject.SetActive(false);
            }
            else
            {
                generatingCloudPoint[random].gameObject.SetActive(true);
            }
            spawnBetweenTimeCounter = spawnBetwenTime;
        }
        else {
            spawnBetweenTimeCounter -= Time.deltaTime;
        }
        */


	}

}
