using UnityEngine;
using System.Collections;

public class DeathTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider coll){
		if(coll.gameObject.name == "MetalBall"){
			if(StateManager.lives >= 0){
				StateManager.lives -= 1;
				StateManager.scoreMultiplier = 1;
				coll.gameObject.transform.position = new Vector3(-1.08f,1.73f,-15.06f);
			}
			else{
				Application.LoadLevel("Pinball_Intro");
			}

		}
	}
}
