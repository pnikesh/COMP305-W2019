using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEndTrigger : MonoBehaviour
{
    public GameObject ui_endLevelPanel;
   //REserved by Unity to detect whrn an object  enters a collider
   void OnTriggerEnter2D(Collider2D other)
   {
       if(other.CompareTag("Player")){
           //show my UI Panel
           ui_endLevelPanel.SetActive(true);
       }
   }
}
