/****
 * Created by: Kameron Eaton
 * Date Created: Feb 7, 2022
 * 
 * Last Edited by: NA
 * Last Edited: Feb 7, 2022
 * 
 * Description: Manages the main menu for the game
 ****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Loads the game scene
    }//end PlayGame

    public void QuitGame()
    {
        Application.Quit(); //closes the application
    }//end QuitGame
}//end MainMenu
