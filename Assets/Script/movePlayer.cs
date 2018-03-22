using UnityEngine;

public class movePlayer : MonoBehaviour {

	public float rotateSpeed = 150.0f;
	public float runningSpeed = 15.0f;

	void Update () {
		var x = Input.GetAxis ("Horizontal") * Time.deltaTime * rotateSpeed;
		var z = Input.GetAxis ("Vertical") * Time.deltaTime * runningSpeed;

		transform.Rotate (0, x, 0);
		transform.Translate (0, 0, z);
	}
}
