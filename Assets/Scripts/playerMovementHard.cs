using UnityEngine;
using System.Collections;

public class playerMovementHard : MonoBehaviour {

	public float speed = 30f;

	void Start () 
	{

	}


	void Update () {

		if (Input.GetKey (KeyCode.UpArrow) && transform.position.x > -67f) 
		{
			transform.Translate (new Vector3 (-1, 0, 0) * speed * Time.deltaTime);
		}
		else if (Input.GetKey (KeyCode.DownArrow) && transform.position.x < 17.8f) 
		{
			transform.Translate (new Vector3 (1, 0, 0) * speed * Time.deltaTime);
		} 
		else if (Input.GetKey (KeyCode.LeftArrow) && transform.position.z > -67.4f) 
		{
			transform.Translate (new Vector3 (0, 0, -1) * speed * Time.deltaTime);
		} 
		else if (Input.GetKey (KeyCode.RightArrow) && transform.position.z < 17.8f) 
		{
			transform.Translate (new Vector3 (0, 0, 1) * speed * Time.deltaTime);
		}

	}
}
