using UnityEngine;
using System.Collections;

public class ScaleDown : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


		transform.localScale = new Vector3(StateManager.rewindPercent,
		                                   transform.localScale.y,
		                                   transform.localScale.z);

	}
}
