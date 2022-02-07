/****
 * Created by: Kameron Eaton
 * Date Created: Jan 31, 2022
 * 
 * Last Edited by: NA
 * Last Edited: Feb 7, 2022
 * 
 * Description: Handles the destruction of the apples that miss the basket
 ****/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < bottomY)
        {
            Destroy(this.gameObject); //destroy game object
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>(); //get ApplePicker script from main camera
            apScript.AppleDestroyed(); //call AppleDestroyed in the ApplePicker function
        }//end if
    }//end Update
}//end Apple
