using UnityEngine;
using System.Collections;

public class ExitScript : MonoBehaviour {

	private float timer = 0;

	void Start () 
	{
	
	}
	

	void Update ()
	{
		timer += Time.deltaTime;
		if (timer >= 0.5f) {
			if (this.gameObject.GetComponent<CubeManagerMenu> ().Accept () == 1) {
				Application.Quit ();
			}
			timer = 0;
		}

	}


}