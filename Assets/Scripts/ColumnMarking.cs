using UnityEngine;
using System.Collections;

public class ColumnMarking : MonoBehaviour {

	GameObject player;
	public Material row;
	public Material notRow;

	void Start () {
		
			if (GameObject.Find ("Player")) {
				player = GameObject.Find ("Player");
			} else if (GameObject.Find ("PlayerMedium")) {
				player = GameObject.Find ("PlayerMedium");
			} else {
				player = GameObject.Find ("PlayerHard");
			}

	}



	void Update () {
		if (player.transform.position.z >= transform.position.z - 2f && player.transform.position.z <= transform.position.z + 2f) {
			GetComponent<Renderer> ().sharedMaterial = row;
		} else {
			GetComponent<Renderer> ().sharedMaterial = notRow;
		}


	}

}
