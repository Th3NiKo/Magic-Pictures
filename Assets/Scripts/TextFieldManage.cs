using UnityEngine;
using System.Collections;

public class TextFieldManage : MonoBehaviour {

	public string value = "0"; 
	public float goDownBy = 1.8f;
	public GameObject textObject;
	TextMesh meshOfText;
	void Start()
	{
		Vector3 textPosition = new Vector3 (transform.position.x - goDownBy, 0.5f, transform.position.z);
		GameObject actualText = (GameObject)Instantiate (textObject, textPosition, Quaternion.Euler(90.0f, 270.0f, 0.0f));
		actualText.transform.SetParent (this.transform);
		meshOfText = actualText.GetComponent<TextMesh> ();
		meshOfText.text = value;
	}



}
