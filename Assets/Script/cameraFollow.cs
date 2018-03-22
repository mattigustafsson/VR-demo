using UnityEngine;

public class cameraFollow : MonoBehaviour {

	public Transform target;
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = target.position;
		transform.rotation = target.rotation;
	}
}
