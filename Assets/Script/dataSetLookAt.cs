using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dataSetLookAt : MonoBehaviour {

	Camera cam;
	public GameObject rotateAround;

	void Start () {
		cam = Camera.main;
	}

	// Update is called once per frame
	void Update () {
		Vector3 targetPostition = new Vector3 (cam.transform.position.x, this.transform.position.y, cam.transform.position.z);
		transform.LookAt (targetPostition);
		//transform.RotateAround(rotateAround.transform.position, Vector3.up, 2);
		

	}
}
