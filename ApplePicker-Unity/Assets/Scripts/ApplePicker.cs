/****
 * Created by: Kameron Eaton 
 * Date Created: Jan 31, 2022
 * 
 * Last Edited by: NA
 * Last Edited: Feb 7, 2022
 * 
 * Description: Game manager script
 ****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    [Header("SET IN INSPECTOR")]
    public GameObject basketPrefab;
    public GameOver gameOver;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;
    // Start is called before the first frame update
    void Start()
    {
        basketList = new List<GameObject>();
        for(int i = 0; i<numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }//end for
    }//end Start

    // Update is called once per frame
    void Update()
    {
        
    }//end Update

    public void AppleDestroyed()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach(GameObject tGo in tAppleArray)
        {
            Destroy(tGo); //clear screen of all apples for a short moment
        }//end foreach

       
      
        int basketIndex = basketList.Count - 1; //Get index of the last basket in basketList
        GameObject tBasketGO = basketList[basketIndex]; //reference to Basket GameObject
        basketList.RemoveAt(basketIndex); //removes basket from the list
        Destroy(tBasketGO); //destroys the removed basket

        if(basketList.Count == 0)
        {
            EndGame();
        }//end if
    }//end AppleDestroyed

    public void EndGame()
    {
        gameOver.Setup();
    }
}//end ApplePicker
