/****
 * Created by: Kameron Eaton 
 * Date Created: Jan 31, 2022
 * 
 * Last Edited by: NA
 * Last Edited: Jan 31, 2022
 * 
 * Description: Game manager script
 ****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    [Header("SET IN INSPECTOR")]
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i<numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
