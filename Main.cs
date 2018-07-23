using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour {

    public static int Score { get; set; }
    public Text textScore;

    // Use this for initialization
    void Start () {
        Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        textScore.text = Score.ToString();
    }
}
