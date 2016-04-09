using UnityEngine;
using System.Collections;

public class DebugOutput : MonoBehaviour {

	public GameObject DebugText;

	public TextMesh DebugTextMesh;
	// Use this for initialization
	void Start () {
		DebugTextMesh = DebugText.GetComponent<TextMesh> ();
	}
	
	// Update is called once per frame
	void Update () {
		DebugTextMesh.text = "Position: " + transform.position;
		if (transform.position.z >= 1) {
			Application.LoadLevel("VRScene");
		}
	}
}
