using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLevelsController : MonoBehaviour
{
    [SerializeField] private GameObject levelsPanel;
    [SerializeField] private GameObject menuPanel;
    public void Level1()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level_2");

    }
    public void Level3()
    {
        SceneManager.LoadScene("Level_3");

    }
    public void Level4()
    {
        SceneManager.LoadScene("Level_4");

    }

    public void Level5()
    {
        SceneManager.LoadScene("Level_5");

    }

    public void GoBackToMenu()
    {
        levelsPanel.SetActive(false);
        menuPanel.SetActive(true);
    }
}
