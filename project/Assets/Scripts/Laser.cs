﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
	public bool noObstacle=true;
	//private GameObject obstacle;


	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay (Collider other) { //other is the other object colliding with the laser
		//Detects if there is an obstacle
		Debug.Log (other + other.tag);
		if ((other.tag !=("Character"))&&(other.tag !="Head")) {
			noObstacle = false;

		} else if(other.tag=="Character")
			noObstacle = true;

	}

}


