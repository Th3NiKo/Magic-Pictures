using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelChoosen : MonoBehaviour {


	public string sceneName = "easy1";


	bool changed = false;

	void Start ()
	{
		//PlayerPrefs.SetInt("easy" + gameObject.GetComponent<TextFieldManage>().value, 1);
	}
	

	void Update () 
	{


			if (PlayerPrefs.GetInt ("easy" + gameObject.GetComponent<TextFieldManage> ().value) == 1 && changed == false) {
				gameObject.GetComponent<CubeManager> ().changeForNotAcceptedColor ();
				changed = true;

			}
			if (this.gameObject.GetComponent<CubeManager> ().Accept () == 1) {
				SceneManager.LoadScene (sceneName);
			}
			
			

	}
}
