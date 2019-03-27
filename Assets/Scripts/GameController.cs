using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public UI_CherryCounter ui_cherryCounter;
    private int itemCounter = 0;  //how many items picked up
    private int totalItemCount = 0;  //how many item are in my level


    // Start is called before the first frame update
    void Start()
    {
        totalItemCount = GameObject.FindGameObjectsWithTag("Item").Length;
        ui_cherryCounter.UpdateUI(itemCounter, totalItemCount);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
