using UnityEngine;
using System.Collections;

public class WinnerMovement : MonoBehaviour {

	public float positionToStop = -4.5f;
	public float speed = 10f;
	void Start () {
	
	}
	

	void Update () {
		if (transform.position.z > positionToStop) {
			transform.Translate (0f, 0f, -1f * speed * Time.deltaTime);

		}
	
	}
}
