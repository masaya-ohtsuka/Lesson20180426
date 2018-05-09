using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public float timeCount;
    public Text timeLabel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        timeCount -= Time.deltaTime;

        timeLabel.text = "時間:" + timeCount.ToString("n2");

        if (timeCount < 0) {
            SceneManager.LoadScene("GameOver");
        }
	}
}
