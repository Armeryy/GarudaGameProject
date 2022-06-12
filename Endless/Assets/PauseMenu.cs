using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField]
    public GameObject pauseMenu;

    public static bool isPaused;


    public static PauseMenu Instance;

    void DestroyGameManager()
    {
        if (GameObject.Find("GameManager") != null)
        {
            PauseMenu.Instance = null;
            Destroy(GameObject.Find("GameManager"));
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;   
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().name == "Level0" ||
            SceneManager.GetActiveScene().name == "Level1")
            {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
            }
        }
    }


    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f; 
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void GoToMainMenu()
    {
        DestroyGameManager();
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
     public void QuitGame()
     {
         Application.Quit();
     }
}
