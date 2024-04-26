using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    //GameObject player;
    Move playerMove;
    public GameObject TabToStartPanel;
    
    private void Awake()
    {
        //player = GameObject.FindGameObjectWithTag("player");
        //player.GetComponent<Move>().speed = 0;
        playerMove=GameObject.FindGameObjectWithTag("Player").GetComponent<Move>();
        playerMove.speed = 0;

    }

    public void TapToStart()
    {
       
        TabToStartPanel.SetActive(false);
        playerMove.speed = 15;
    }
  


}
