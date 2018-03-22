using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dataSetSpawner : MonoBehaviour {

	public GameObject DataSets;
	private GameObject parent;

	void Start () {
		parent = GameObject.Find ("RotateAround");
	}

	void OnMouseUp () {
		if (GameObject.Find ("DataSets(Clone)") == null) {
			Instantiate (DataSets, parent.transform, false);
		}
	}
}
