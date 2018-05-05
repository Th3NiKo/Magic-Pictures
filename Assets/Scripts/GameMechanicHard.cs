using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameMechanicHard : MonoBehaviour {

	int boolToInt(bool variable)
	{
		if (variable) {
			return 1;
		} else {
			return 0;
		}
	}

	public Material winnerMaterial;
	public Transform[] tileArray;
	public GameObject WinnerBlock;
	public float winnerX = 9f;
	public float timeToFinish = 4f;
	float timer = 0;
	int isWinner = 0;


	//To create block of winner only once
	bool isCreated = false;

	GameObject[,] mainTile = new GameObject[20,20];

	void Start () 
	{

		int counter = 0;
		for (int i = 0; i < 20; i++) {
			for (int j = 0; j < 20; j++) {
				mainTile[i,j] = GameObject.FindGameObjectWithTag ("Tile").transform.GetChild (counter).gameObject;
				counter++;
			}
		}	
	}


	void Update () 
	{
		timer += Time.deltaTime;
	}

	void FixedUpdate()
	{
		if (timer >= 0.5f) {
			//Checking all for win
			isWinner = 0;
			for (int i = 0; i < 20; i++) {
				for (int j = 0; j < 20; j++) {
					if (mainTile [i, j].gameObject.GetComponent<CubeManager> ().isForWin() != mainTile [i, j].gameObject.GetComponent<CubeManager> ().Accept()) {
						isWinner++;
					}
				}
			}

			//Is it win?
			if (isWinner == 0) {

				//FLASHING TILES WIN
				for (int i = 0; i < 20; i++) {
					for (int j = 0; j < 20; j++) {
						if (mainTile [i, j].gameObject.GetComponent<CubeManager> ().Accept () == 1) {
							mainTile [i, j].gameObject.GetComponent<CubeManager> ().changeForColor (winnerMaterial);
						} else {
							mainTile [i, j].gameObject.GetComponent<CubeManager> ().changeForColor (mainTile [i, j].gameObject.GetComponent<CubeManager> ().Blank);
						}
					}
				}



				Scene scene = SceneManager.GetActiveScene ();
				PlayerPrefs.SetInt (scene.name, 1);
				if (isCreated == false) {
					Instantiate (WinnerBlock, new Vector3 (winnerX, 0.2f, 60.0f), Quaternion.identity);
					isCreated = true;
				}

				Invoke ("backToMenu", timeToFinish);

			}




			timer = 0;
		}

		if (Input.GetKey (KeyCode.Escape)) {
			backToMenu ();
		}

	}

	void backToMenu()
	{
		SceneManager.LoadScene ("GameMenu");
	}

}

