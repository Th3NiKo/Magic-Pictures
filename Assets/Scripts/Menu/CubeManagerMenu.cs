using UnityEngine;
using System.Collections;

public class CubeManagerMenu : MonoBehaviour {


	float timer = 0;
	public bool forWin = false;
	bool isChoosed = false;
	public int isAccepted = 0; 
	/*
	 * 0 - Blank
	 * 1 - Accepted
	 * 2 - NonAccepted
	 * */

	Renderer rend;
	RaycastHit hit;
	public Material Accepted;
	public Material NotAccepted;
	public Material Blank;

	GameObject[] mainTile = new GameObject[5];

	void Start () 
	{

		for(int i = 0; i < 5; i++)
		{
			mainTile [i] = GameObject.FindGameObjectWithTag ("Tile").transform.GetChild (i).gameObject;
		}	

		rend = GetComponent<Renderer> ();
		rend.enabled = true;
	}



	void Update () 
	{
		timer += Time.deltaTime;
		if (timer >= 0.5f) {
			if (Input.GetKey (KeyCode.Space) && isChoosed) {
				changeAllForBlank ();
				changeForAcceptedColor ();
				timer = 0;
			}
		}


	}

	public void changeForAcceptedColor()
	{
		if (rend.sharedMaterial.name == "Tile" || rend.sharedMaterial.name == "TileNotAccepted") {
			rend.sharedMaterial = Accepted;
			isAccepted = 1;
		} else if (rend.sharedMaterial.name == "TileAccepted") {
			rend.sharedMaterial = Blank;
			isAccepted = 0;
		}
	}

	public void changeForNotAcceptedColor()
	{
		if (rend.sharedMaterial.name == "Tile" || rend.sharedMaterial.name == "TileAccepted") {
			rend.sharedMaterial = NotAccepted;
			isAccepted = 2;
		} else if (rend.sharedMaterial.name == "TileNotAccepted") {
			rend.sharedMaterial = Blank;
			isAccepted = 0;
		}
	}

	public void changeForBlankColor()
	{
		rend.sharedMaterial = Blank;
		isAccepted = 0;
	}

	public void changeAllForBlank()
	{
		for (int i = 0; i < 5; i++) {
			mainTile [i].gameObject.GetComponent<CubeManagerMenu> ().changeForBlankColor ();
		}


	}

	void OnCollisionEnter(Collision obj)
	{
		isChoosed = true;
	}

	void OnCollisionExit(Collision obj)
	{
		isChoosed = false;
	}

	public int Accept()
	{
		if (isAccepted == 0 || isAccepted == 2) {
			return 0;
		} else {
			return 1;
		}
	}

	public int isForWin()
	{
		if (forWin) {
			return 1;
		} else {
			return 0;
		}
	}
}
