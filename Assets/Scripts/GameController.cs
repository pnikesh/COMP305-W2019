using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class GameController : MonoBehaviour
{
    [Header("User Interface")]
    public UI_CherryCounter ui_cherryCounter;
    public GameObject ui_EndLevelPanel;

    [Header("Audio")]
    public AudioMixerSnapshot paused;
    public AudioMixerSnapshot unpaused;
    private int itemCounter = 0;  //how many items picked up
    private int totalItemCount = 0;  //how many item are in my level


    // Start is called before the first frame update
    void Start()
    {
        totalItemCount = GameObject.FindGameObjectsWithTag("Item").Length;
        ui_cherryCounter.UpdateUI(itemCounter, totalItemCount);


    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            //set audo snapshot to pause or unpause snapshot
            //pause the game
            Time.timeScale = Time.timeScale == 0 ? 1 : 0;

            if(Time.timeScale == 0) //paused
            {
                paused.TransitionTo(0.01f);
            }
            else //unpaused
            {
                unpaused.TransitionTo(0.01f);
            }
        }
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
