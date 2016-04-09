using UnityEngine;
using System.Collections;

public class TriggerHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider) {
		Application.LoadLevel("VRScene");
	}
}
