using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class HelloWorld : MonoBehaviour
{
    //Ýntegers
    byte levelNo = 255;
    sbyte withPositive = 127;
    short smallNo = 32_000;
    ushort smallNoNegative = 64_000;
    public int speed = 50;
    uint speed2 = 25;
    long bigNumber = 1_000_000_000_000_000_000;
    
    //Decimals
    float kesirliSayi = 10.5f;
    double doubleDecimal = 10.7;
    decimal decNo = 22.5m;

    //Charecters
    String myText = "Hello World 2!!";
    char smiley = 's';

    //Unity ozel
   // public GameObject helloText;

    // Start is called before the first frame update
    void Start()
    {
       // print(myText); // console mesaji
       // Application.targetFrameRate = 100; // Oyunun fpsini sabitleme
       // helloText.GetComponent<TextMeshPro>().text = "Hello World!!";
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Hello Again");
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
    }
}
