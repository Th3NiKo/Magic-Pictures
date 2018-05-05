using UnityEngine;
using System.Collections;

public class RowMarking : MonoBehaviour {

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
		if (player.transform.position.x >= transform.position.x - 2f && player.transform.position.x <= transform.position.x + 2f) {
			GetComponent<Renderer> ().sharedMaterial = row;
		} else {
			GetComponent<Renderer> ().sharedMaterial = notRow;
		}
	

	}

}
