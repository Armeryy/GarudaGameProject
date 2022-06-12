using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{

    void DestroyGameManager()
    {
        if (GameObject.Find("GameManager") != null)
        {
            PauseMenu.Instance = null;
            Destroy(GameObject.Find("GameManager"));
        }
    }

    void DestroyPauseMenu()
    {
        if (GameObject.Find("PauseMenu") != null)
        {
            PauseMenu.Instance = null;
            Destroy(GameObject.Find("PauseMenu"));
        }
    }

    void Awake()
    {
        DestroyPauseMenu();
    }

    public void Retry()
    {
        DestroyGameManager();
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
         Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
