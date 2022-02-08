/****
 * Created by: Kameron Eaton
 * Date Created: Feb 7, 2022
 * 
 * Last Edited by: NA
 * Last Edited: Feb 7, 2022
 * 
 * Description: Manages and stores the high score earned in the game
 ****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    static public int score = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }//end Start

    private void Awake()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            score = PlayerPrefs.GetInt("HighScore"); // reads high score
        }//end if

        PlayerPrefs.SetInt("HighScore", score); // assigns high score to HighScore
    }//end Awake

    // Update is called once per frame
    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: " + score;

        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score); // Update HighScore if necessary
        }//end if

    }//end Update
}//end HighScore
