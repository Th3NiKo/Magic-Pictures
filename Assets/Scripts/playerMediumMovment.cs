using UnityEngine;
using System.Collections;

public class playerMediumMovment : MonoBehaviour {


		public float speed = 30f;

		void Start () 
		{

		}


		void Update () {

			if (Input.GetKey (KeyCode.UpArrow) && transform.position.x > -22f) 
			{
				transform.Translate (new Vector3 (-1, 0, 0) * speed * Time.deltaTime);
			}
			else if (Input.GetKey (KeyCode.DownArrow) && transform.position.x < 18f) 
			{
				transform.Translate (new Vector3 (1, 0, 0) * speed * Time.deltaTime);
			} 
			else if (Input.GetKey (KeyCode.LeftArrow) && transform.position.z > -22f) 
			{
				transform.Translate (new Vector3 (0, 0, -1) * speed * Time.deltaTime);
			} 
			else if (Input.GetKey (KeyCode.RightArrow) && transform.position.z < 17.8f) 
			{
				transform.Translate (new Vector3 (0, 0, 1) * speed * Time.deltaTime);
			}

		}


}

