using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiyokoGenerator : MonoBehaviour {

	public GameObject obj;
	public float interval = 3.0f;

	// Use this for initialization
		void Start () {
		InvokeRepeating ("SpawnObj", 0.1f, interval); 	
	}
	
	// Update is called once per frame
	void SpawnObj () {
		Instantiate (obj, transform.position,transform.rotation);
	}
}
