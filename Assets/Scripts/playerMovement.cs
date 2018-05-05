using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	public float speed = 5f;
	bool up, down, left, right;
	Transform startingPos;
	float moveRightBy = 4.5f;
	float moveLeftBy = -4.5f;
	float moveUpBy = -4.5f;
	float moveDownBy = 4.5f;



	void Start()
	{
		transform.position = new Vector3 (transform.position.x, 1.2f, transform.position.z);
		startingPos = this.gameObject.GetComponent<Transform>();	
		up = false;
		down = false;
		left = false;
		right = false;
	}
	void Update () 
	{
		if (Input.GetKey (KeyCode.UpArrow) && transform.position.x > 0.2f) 
		{
			up = true;
		}
		else if (Input.GetKey (KeyCode.DownArrow) && transform.position.x < 17.8f) 
		{
			down = true;
		} 
		else if (Input.GetKey (KeyCode.LeftArrow) && transform.position.z > 0.2f) 
		{
			left = true;
		} 
		else if (Input.GetKey (KeyCode.RightArrow) && transform.position.z < 17.8f) 
		{
			right = true;
		}

		if (up) {
			goUp ();
		} else if (down) {
			goDown ();
		} else if (left) {
			goLeft ();
		} else if (right) {
			goRight ();
		}
	
	}

	void goUp()
	{
		Vector3 aim = new Vector3 (transform.position.x - 4.5f, transform.position.y, transform.position.z);
		transform.position = Vector3.MoveTowards (transform.position, aim, speed * Time.deltaTime);
		if (startingPos.position.x <= moveUpBy) {
			startingPos.position.Set (transform.position.x, startingPos.position.y, startingPos.position.z);
			moveDownBy -= 4.5f;
			moveUpBy -= 4.5f;
			up = false;
		}
	}

	void goDown()
	{
		Vector3 aim = new Vector3 (transform.position.x + 4.5f, transform.position.y, transform.position.z);
		transform.position = Vector3.MoveTowards (transform.position, aim, speed * Time.deltaTime);
		if (startingPos.position.x >= moveDownBy) {
			startingPos.position.Set (transform.position.x, startingPos.position.y, startingPos.position.z);
			moveDownBy += 4.5f;
			moveUpBy += 4.5f;
			down = false;
		}
	}

	void goLeft()
	{
		Vector3 aim = new Vector3 (transform.position.x, transform.position.y, transform.position.z - 4.5f);
		transform.position = Vector3.MoveTowards (transform.position, aim, speed * Time.deltaTime);
		if (startingPos.position.z <= moveLeftBy) {
			startingPos.position.Set (startingPos.position.x, startingPos.position.y, transform.position.z);
			moveLeftBy -= 4.5f;
			moveRightBy -= 4.5f;
			left = false;
		}
	}

	void goRight()
	{
		Vector3 aim = new Vector3 (transform.position.x, transform.position.y, transform.position.z + 4.5f);
		transform.position = Vector3.MoveTowards (transform.position, aim, speed * Time.deltaTime);
		if (startingPos.position.z >= moveRightBy) {
			startingPos.position.Set (startingPos.position.x, startingPos.position.y, transform.position.z);
			moveRightBy += 4.5f;
			moveLeftBy += 4.5f;
			right = false;
		}
	}


}
