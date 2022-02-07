/****
 * Created by: Kameron Eaton
 * Date Created: Feb 2, 2022
 * 
 * Last Edited by: NA
 * Last Edited: Feb 7, 2022
 * 
 * Description: Manages the creation of baskets and what happens when they collide with apples.
 ****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//using UI Libraries

public class Basket : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreGT;



    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");//score game object
        scoreGT = scoreGO.GetComponent<Text>();//text component of the score game object
        scoreGT.text = "0";//set the text property
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition; //gets current screen position of the mouse

        mousePos2D.z = -Camera.main.transform.position.z; //The camera's z position sets how far to push the mouse into 3D

        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D); //converts point from 2D screen to 3D game world
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos; //Move the x position of the basket to x position of the mouse
    }

    private void OnCollisionEnter(Collision coll)
    {
        // Find out what hit the basket
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);

            int score = int.Parse(scoreGT.text);
            score += 100;
            scoreGT.text = score.ToString();
        }
    }
}
