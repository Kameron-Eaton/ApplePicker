/****
*Created by: Kameron Eaton
*Date Created: Feb 7, 2022
*
*Last Edited by: NA
*Last Edited: Feb 7, 2022
*
*Description: Manages the end of the game and the game over screen
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text scoreGT;
    public TextMeshProUGUI final;
    public AppleTree appleTree;
   public void Setup()
    {
        gameObject.SetActive(true);
        appleTree.stopInvoke();
        GameObject scoreGO = GameObject.Find("ScoreCounter");//score game object
        GameObject finalScore = GameObject.Find("FinalScore");
        scoreGT = scoreGO.GetComponent<Text>();//text component of the score game object
        final = finalScore.GetComponent<TextMeshProUGUI>();
        int score = int.Parse(scoreGT.text);
        final.text = score.ToString() + " POINTS";

    }//end Setup

    public void PlayAgain()
    {
        SceneManager.LoadScene("_Scene-00");
    }

    public void Quit()
    {
        SceneManager.LoadScene("Start");
    }

}
