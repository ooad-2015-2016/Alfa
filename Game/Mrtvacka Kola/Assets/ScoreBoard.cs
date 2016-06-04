using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {

    public Text score;
	// Use this for initialization
	void Start () {
        string timeScore = PlayerPrefs.GetString("vrijemeProvedeno", "null");
        score.text = timeScore;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
