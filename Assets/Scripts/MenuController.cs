using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject levelsPanel;
    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject creditsPanel;

    public void StartButton()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void LevelsButton()
    { 
        menuPanel.SetActive(false);
        levelsPanel.SetActive(true);
    }

    public void CreditsButton()
    {
        menuPanel.SetActive(false);
        creditsPanel.SetActive(true);
    }
    public void ExitButton()
    {
        Application.Quit();
    }
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
        creditsPanel.SetActive(false);
        menuPanel.SetActive(true);
    }

}