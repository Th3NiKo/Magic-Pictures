using UnityEngine;
using System.Collections;

public class PlayerMovementMenu : MonoBehaviour {

	public float speed = 15f;
	public float Max = 1f;

	void Start () 
	{

	}


	void Update () {

		if (Input.GetKey (KeyCode.UpArrow) && transform.position.x > 0.2f) 
		{
			transform.Translate (new Vector3 (-1, 0, 0) * speed * Time.deltaTime);
		}
		else if (Input.GetKey (KeyCode.DownArrow) && transform.position.x < Max) 
		{
			transform.Translate (new Vector3 (1, 0, 0) * speed * Time.deltaTime);
		} 
		else if (Input.GetKey (KeyCode.LeftArrow) && transform.position.z > 0.2f) 
		{
			transform.Translate (new Vector3 (0, 0, -1) * speed * Time.deltaTime);
		} 
		else if (Input.GetKey (KeyCode.RightArrow) && transform.position.z < 17.8f) 
		{
			transform.Translate (new Vector3 (0, 0, 1) * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.Space)) {
			changeMax (17.8f);
		}

	}

	public void changeMax(float x)
	{
		Max = x;
	}
}
