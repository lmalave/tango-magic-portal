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
		Vector3 cameraXZ = new Vector3 (transform.position.x, 0, transform.position.z);
		string text = "cam pos: " + cameraXZ;
		foreach(GameObject door in GameObject.FindGameObjectsWithTag("door"))
		{
			Vector3 doorXZ = new Vector3 (door.transform.position.x, 0,door.transform.position.z);
			text = text + ", door pos: " + doorXZ;
			if (Vector3.Distance(cameraXZ, doorXZ) < 0.5) {
				Application.LoadLevel("VRScene");
			}
		}
		DebugTextMesh.text = "Position: " + text;
	}
}
