using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Move : MonoBehaviour
{
    public int speed=15, Score = 0;
    // public Transform LeftPoint, RightPoint, MidPoint;
    // public int LeftPos,RightPos,MidPos;
    public bool atLeft, atRight, atMid = true, onMove = false;



    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,0,1)*Time.deltaTime*speed);
        if(Input.GetKeyDown(KeyCode.A) && atLeft == false &&!onMove)
        {


            if (atMid)
            {
                atLeft = true;
                atMid =false;
            }
            else if(atRight)
            {
                atRight = false;
                atMid = true;
            }
            // transform.position=new Vector3(transform.position.x - 4.5f,transform.position.y,transform.position.z);
            transform.DOMoveX(transform.position.x - 4.5f, 0.25f).SetEase(Ease.Linear).OnComplete(OnMoveToFalse);
            onMove = true;

        }
        if (Input.GetKeyDown(KeyCode.D) && atRight == false && !onMove)
        {

           
            if (atMid)
            {
                atRight = true;
                atMid = false;
            }
            else if (atLeft)
            {
                atLeft = false;
                atMid = true;
            }

            //transform.position = new Vector3(transform.position.x + 4.5f, transform.position.y, transform.position.z);
            transform.DOMoveX(transform.position.x + 4.5f, 0.25f).SetEase(Ease.Linear).OnComplete(OnMoveToFalse);
            onMove = true;
        }
    }

    void OnMoveToFalse()
    {
        onMove = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            speed = 0;
        }
        if(other.CompareTag("Obstacle"))
        {
            speed = 0;
        }
        if (other.CompareTag("Point"))
        {
            Score++;
            other.gameObject.SetActive(false);
        }
    }


}
