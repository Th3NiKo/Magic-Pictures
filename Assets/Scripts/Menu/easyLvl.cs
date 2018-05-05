/*
 * Value to use 4.4319f, -3.288f, -38f for movement
 * 
 * 
 * */



using UnityEngine;
using System.Collections;

public class easyLvl : MonoBehaviour {

	float timer = 0;
	public GameObject easyLevels;
	public string whatToDestroy = "EasyLevels(Clone)";
	GameObject easyObject;
	bool exist = false;


	void Start () {
		easyObject = GameObject.Find ("EMPTY");
	}
	

	void Update () {
		timer += Time.deltaTime;

		if (timer >= 0.5f ) {
			if (!exist) {
				if (this.gameObject.GetComponent<CubeManagerMenu> ().Accept () == 1) {
					exist = true;

					easyObject = (GameObject)Instantiate (easyLevels, new Vector3 (4.4319f, -3.288f, 9.653f), Quaternion.identity);

				} 
			} else {
				if (this.gameObject.GetComponent<CubeManagerMenu> ().Accept () == 0) {
					Destroy (GameObject.Find (whatToDestroy));
					exist = false;
				}
			}
		}
	}
}
