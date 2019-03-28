using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public UI_CherryCounter ui_cherryCounter;
    public GameObject ui_EndLevelPanel;
    private int itemCounter = 0;  //how many items picked up
    private int totalItemCount = 0;  //how many item are in my level


    // Start is called before the first frame update
    void Start()
    {
        totalItemCount = GameObject.FindGameObjectsWithTag("Item").Length;
        ui_cherryCounter.UpdateUI(itemCounter, totalItemCount);


    }

    //called when item is picked up
    public void PickUpItem()
    {
        ui_cherryCounter.UpdateUI(++itemCounter, totalItemCount);
    }

    public void LevelEnd()
    {
        ui_EndLevelPanel.SetActive(true);
        //ui_EndLevelPanel.transform.GetChild(2).GetComponent<Text>().text = "SOMETHING";
        ui_EndLevelPanel.GetComponentInChildren<UI_CherryCounter>().UpdateUI(itemCounter, totalItemCount);
    }
}
