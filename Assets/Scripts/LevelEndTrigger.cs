using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEndTrigger : MonoBehaviour
{
    public GameObject ui_endLevelPanel;
    private GameController gCont;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
       gCont = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

   //REserved by Unity to detect whrn an object  enters a collider
   void OnTriggerEnter2D(Collider2D other)
   {
       if(other.CompareTag("Player")){
            
            
           //show my UI Panel by calling GameController method
           gCont.LevelEnd();
       }
   }
}
