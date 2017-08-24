using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidspawn : MonoBehaviour {
    public float delay = 0.1f;
    public GameObject sphere;
	// Use this for initialization
	void Start () {
    InvokeRepeating("Spawn", delay, delay);
	}
	
	// Update is called once per frame
	void Spawn () {
    Instantiate(sphere, new Vector3(Random.Range(-6, 6), 10, 3.1f),Quaternion.identity);
	}
}
