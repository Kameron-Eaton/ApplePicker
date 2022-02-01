using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
        }
    }
}
