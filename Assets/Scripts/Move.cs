using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public int speed = 1, coinCount = 0, heartCount = 1;
    public float leftBorder = -2.5f, rightBorder = 2.5f;
    //float height = 1.25f;
    float transSpeed = 0.25f;
    public bool onLeft = false, mid = true, onRight = false;


    public void animPlay(string animName)
    {
        GetComponent<Animator>().SetBool("Run", false);
        GetComponent<Animator>().SetBool("Idle", false);
        GetComponent<Animator>().SetBool("Die", false);
        GetComponent<Animator>().SetBool(animName, true);
    }

    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    if(hit.gameObject.CompareTag("Obstacle"))
    //    {
    //        animPlay("Die");
    //        speed = 0;
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
        //GetComponent<CharacterController>().Move(new Vector3(0, 0, 1) * Time.deltaTime * speed);

        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    GetComponent<Animator>().SetBool("Run", true);
        //    animPlay("Run");
        //    speed = 200;
        //}
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().SetTrigger("Jump");
            //transform.DOJump(new Vector3(transform.position.x,2,transform.position.z), 1, 1, 0.5f);
            transform.DOMoveY(4, 0.5f);
            transform.DOMoveY(0, 1f).SetDelay(0.5f);
        }
        if (Input.GetKeyDown(KeyCode.A) && onLeft == false && mid == true)
        {
            onLeft = true;
            mid = false;
            transform.DOMoveX(leftBorder, transSpeed);
            GetComponent<Animator>().SetTrigger("GoLeft");
            //transform.position = new Vector3(-2, height, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.A) && mid == false && onRight == true)
        {
            onRight = false;
            mid = true;
            transform.DOMoveX(0, transSpeed);
            GetComponent<Animator>().SetTrigger("GoLeft");
            //transform.position = new Vector3(0, height, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.D) && onRight == false && mid == true)
        {
            onRight = true;
            mid = false;
            transform.DOMoveX(rightBorder, transSpeed);
            GetComponent<Animator>().SetTrigger("GoRight");
            //transform.position = new Vector3(2, height, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.D) && onLeft == true && mid == false)
        {
            onLeft = false;
            mid = true;
            transform.DOMoveX(0, transSpeed);
            GetComponent<Animator>().SetTrigger("GoRight");
            //transform.position = new Vector3(0, height, transform.position.z);
        }
    }


}
