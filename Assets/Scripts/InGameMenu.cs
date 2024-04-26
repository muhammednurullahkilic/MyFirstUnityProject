using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGameMenu : MonoBehaviour
{


    public GameObject inGameMenu;

    private void Start()
    {
        CloseInGameMenu();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && inGameMenu.activeInHierarchy)
        {
            inGameMenu.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && !inGameMenu.activeInHierarchy)
        {
            inGameMenu.SetActive(true);
            
        }


        if(inGameMenu.activeInHierarchy)
        {

        }
    }

    public void CloseInGameMenu()
    {
        inGameMenu.SetActive(false);
    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    


}
