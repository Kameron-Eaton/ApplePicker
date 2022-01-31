/****
*Created by: Kameron Eaton
*Date Created: Jan 31, 2022
*
*Last Edited by: NA
*Lasted Edited: Jan 31, 2022
*
*Description: Controls the movement of the AppleTree
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    /**** VARIABLES ****/
    [Header("SET IN INSPECTOR")]
    public float speed = 1f; //tree speed
    public float leftAndRightEdge = 10f; //distane where the tree turns around
    public GameObject applePrefab; //prefab of instantiating apples
    public float secondsBetweenApplesDropped = 1f; //time between apple drops
    public float chanceToChangeDirections = 0.1f; //chance that the tree will change directions




    // Start is called before the first frame update
    void Start()
    {
        
    }//end Start

    // Update is called once per frame
    void Update()
    {
        //Basic Movement
        Vector3 pos = transform.position; //records current position
        pos.x += speed * Time.deltaTime; //adds speed to x position
        transform.position = pos; //apply the position value

        //Change Direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //set speed to positive
        }//end if
        else if(pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }//end if
    }//end Update


    //FixedUpdate is called on fixed intervals (50 times per second)
    private void FixedUpdate()
    {
        //Test chance of direction change   
        if(Random.value < chanceToChangeDirections)
        {
            speed *= -1; //change directions
        }//end if
    }//end FixedUpdate
}//end AppleTree
