using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelChoosenMedium : MonoBehaviour {
	
	public string sceneName = "easy1";
	bool changed = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.HasKey ("medium" + gameObject.GetComponent<TextFieldManage> ().value.ToString())) {
			if (PlayerPrefs.GetInt ("medium" + gameObject.GetComponent<TextFieldManage> ().value.ToString()) == 1 && changed == false) {
				gameObject.GetComponent<CubeManager> ().changeForNotAcceptedColor ();
				changed = true;

			} 


		}
		if (this.gameObject.GetComponent<CubeManager> ().Accept () == 1) {
			SceneManager.LoadScene (sceneName);
		}
	}
}
