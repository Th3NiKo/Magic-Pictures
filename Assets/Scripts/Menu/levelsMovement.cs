using UnityEngine;
using System.Collections;

public class levelsMovement : MonoBehaviour {

	public float speedOfMoving = 10f;

	void Start () 
	{
	
	}
	

	void Update () 
	{
		/*
		if (transform.position.z <= 9.5f) {
			transform.Translate (0f, 0f, 1.0f * speedOfMoving * Time.deltaTime);
		} else {
			GameObject.Find ("Player").GetComponent<PlayerMovementMenu> ().changeMax (17.8f);
		}
		*/
	}
}
