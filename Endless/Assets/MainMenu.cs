using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    public GameObject SettingsMenu;

    void Start()
    {
        SettingsMenu.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }


    void DestroyScoreManager()
    {
            if (GameObject.Find("Score") != null)
            {
                ScoreManager.Instance = null;
               Destroy(GameObject.Find("Score"));
            }


    }

    public void PlayLevel0()
    {
        DestroyScoreManager();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

      public void PlayLevel1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

      public void PlayLevel2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
}
