using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Blink : MonoBehaviour {
	float startTime=0f;
	public float timeRate;
	bool render=true;
	Text txt;
	// Use this for initialization
	void Start () {
		txt = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

			if (Time.time>startTime){
				startTime=Time.time+timeRate;
				txt.enabled = render;
				render=!render;

			}

				
	
	}
}
