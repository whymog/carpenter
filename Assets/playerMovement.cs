using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	public float moveSpeed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("left") && Input.GetKey ("right")) {
			// do nothin'
			return;
		} else if (Input.GetKey ("left")) {
			movePlayer (Vector3.left, moveSpeed);
		} else if (Input.GetKey ("right")) {
			movePlayer (Vector3.right, moveSpeed);
		}
	}

	void movePlayer(Vector3 direction, float factor) {
		transform.position += (direction * factor * Time.deltaTime);
	}
}
