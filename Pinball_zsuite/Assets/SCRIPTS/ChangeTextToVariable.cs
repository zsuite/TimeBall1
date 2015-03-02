using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeTextToVariable : MonoBehaviour {
	public string customText = "Score";

	public enum textVariable{
		SCORE,
		HIGHSCORE,
		TIMER,
		LIVES,
		MULTIPLIER,
		REWINDMETER
	};
	public textVariable switchText;
	Text txt;
	// Use this for initialization

	void Start () {
		txt = GetComponent<Text>();


	}
	
	// Update is called once per frame
	void Update () {
		switch(switchText){
			case textVariable.SCORE:
				txt.text = customText + "\n" + StateManager.score;

				break;
			case textVariable.HIGHSCORE:
				txt.text = customText + "\n"+ StateManager.highscore;

				break;
			case textVariable.TIMER:
				string minutes = Mathf.Floor(StateManager.timer / 60).ToString("00");
				string seconds = (StateManager.timer % 60).ToString("00");
				txt.text = customText + "\n"+ minutes + ":" + seconds;

				break;
			case textVariable.LIVES:
				txt.text = customText + "\n"+ StateManager.lives;

				break;
			case textVariable.MULTIPLIER:
				txt.text = customText + "\nx"+ StateManager.scoreMultiplier;
				
				break;
			case textVariable.REWINDMETER:
				txt.text = customText + "\n"+ (Mathf.Round(StateManager.rewindPercent)) + "%";
			
				break;
		
		}



	
	}
}
