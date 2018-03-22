using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChartSpawn : MonoBehaviour {

	public GameObject Charts;
	private GameObject parent;

	void Start () {
		parent = GameObject.Find ("RotateAround");
	}

	void OnMouseUp () {
		if (GameObject.Find ("Charts(Clone)") == null)
			Instantiate (Charts, parent.transform, true);
	}
}
