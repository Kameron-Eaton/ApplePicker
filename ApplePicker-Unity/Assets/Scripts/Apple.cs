/****
 * Created by: Kameron Eaton
 * Date Created: Jan 31, 2022
 * 
 * Last Edited by: NA
 * Last Edited: Jan 31, 2022
 * 
 * Description: Handles the destruction of the apples
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
            Destroy(this.gameObject);
        }
    }
}
