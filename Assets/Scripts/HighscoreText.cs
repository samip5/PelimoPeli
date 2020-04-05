using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Text))]
public class HighscoreText : MonoBehaviour {

    Text highscore;

    void onEnable() {
        highscore = GetComponent<Text>();
        //highscore.text = PlayerPrefs.GetInt("HighScore").toString();
    }

    void Update() {
        
    }
}
