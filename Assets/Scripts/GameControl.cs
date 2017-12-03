using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

	public static GameControl instance;
	public GameObject gameOverText;
	public Text scoreText;
	public Text highScore;
	public bool gameOver = false;
	public float scrollSpeed = -1.5f;

	private int score = 0;

	void Awake() {
		if (instance == null) {
			instance = this;
		}else if (instance != this) {
			Destroy (gameObject);
		}
	}

	void Start () {
		highScore.text = "High Score: " + PlayerPrefs.GetInt ("HighScore", 0).ToString();
	}

	void Update () {
		if (gameOver == true && Input.GetMouseButtonDown(0)) {
			// reload the current scene
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}
	}

	public void BirdScore() {
		if (gameOver) {
			return;
		}
		score++;
		scoreText.text = "Score: " + score.ToString();

		if (score > PlayerPrefs.GetInt ("HighScore", 0)) {
			PlayerPrefs.SetInt ("HighScore", score);
			highScore.text = "High Score: " + score.ToString();
		}
	}

	public void DolanDied() {
		gameOverText.SetActive(true);
		gameOver = true;
	}
}
