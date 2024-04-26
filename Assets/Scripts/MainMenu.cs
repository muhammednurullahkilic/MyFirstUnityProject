using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject sound;

    public void StartTheGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitTheGame()
    {
        Application.Quit();
    }




}
