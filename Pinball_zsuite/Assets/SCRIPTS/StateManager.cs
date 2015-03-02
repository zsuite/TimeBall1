using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class StateManager : MonoBehaviour {
	public static float timer;
	public static int score;
	public static int scoreMultiplier;
	public static float rewindPercent;
	public static int lives;
	public static int highscore;
	public static float globalPitch = 0.5f;
	public List<GameObject> lifeSprite;

	// Use this for initialization
	void Start () {
		globalPitch = 0.5f;
		timer = 120f;
		score = 0;
		scoreMultiplier = 1;
		rewindPercent = 100;
		lives = 3;
		highscore = PlayerPrefs.GetInt("highscore", 0);

	}
	
	// Update is called once per frame
	void Update () {
		if (timer>0){
			timer -= Time.deltaTime;
		}
		if(timer <= 0){
			Application.LoadLevel("Pinball_Intro");
		}
		SetHighscore(score);
		if(lives == 2){
			DestroyImmediate(lifeSprite[2]);
		}
		if(lives == 1){
			DestroyImmediate(lifeSprite[1]);
		}
		if(lives== 0){
			DestroyImmediate(lifeSprite[0]);
		}
	}
	void SetHighscore(int newHighscore)
	{
		highscore = PlayerPrefs.GetInt("highscore", 0);    
		if(score > highscore){
			PlayerPrefs.SetInt("highscore", score);
		}
	}
}
