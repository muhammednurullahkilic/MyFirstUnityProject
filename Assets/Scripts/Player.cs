using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Move move;
    UIManager uimanager;

    private void Awake()
    {
        move = GetComponent<Move>();
        uimanager = GameObject.Find("GameManager").GetComponent<UIManager>();
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            move.animPlay("Celebrate");
            move.speed = 0;
            //Invoke(nameof(WinCondition), 1);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            move.animPlay("Die");
            move.speed = 0;
            Invoke(nameof(FailCondition), 1);
        }
    }

    void FailCondition()
    {
        uimanager.FailPanel();
    }

    //void WinCondition()
    //{
    //    uimanager.winPanel();
    //}

}
