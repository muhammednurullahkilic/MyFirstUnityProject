using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public GameObject Startpanel, inGamePanel, endPanel, winPanel, failPanel;
    GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OpenPanel(GameObject panelObject, GameObject secondPanel)
    {
        Startpanel.SetActive(false);
        inGamePanel.SetActive(false);
        endPanel.SetActive(false);
        winPanel.SetActive(false);
        failPanel.SetActive(false);
        panelObject.SetActive(true);
        if (secondPanel != null)
        {
            secondPanel.SetActive(true);
        }

    }

    private void Start()
    {
        OpenPanel(Startpanel, null);
    }

    public void FailPanel()
    {
        OpenPanel(failPanel, endPanel);
    }
    

    #region Button Functions
    public void TapToStart()
    {
        Startpanel.SetActive(false);
        inGamePanel.SetActive(true);
        player.GetComponent<Move>().speed = 200;
        player.GetComponent<Move>().animPlay("Run");
    }

    public void Nextlevel()
    {
        int currentLevel = PlayerPrefs.GetInt("CurrentLevel", 1);


        if (currentLevel < 200)
        {
            PlayerPrefs.SetInt("CurrentLevel", currentLevel + 1);
            //SceneManager.LoadScene(currentLevel);

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (currentLevel >= 200)
        {
            PlayerPrefs.SetInt("CurrentLevel", 0);
            SceneManager.LoadScene(0);
        }

    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    #endregion

}





