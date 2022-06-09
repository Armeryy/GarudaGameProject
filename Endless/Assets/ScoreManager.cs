using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private float elapsedTime = 0f;
    
    private int score = 0;

    [SerializeField]
    private TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
    //    Keep Score text to next scene 
        DontDestroyOnLoad(transform.root);
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        score = (int)elapsedTime;
        scoreText.text = score.ToString();
    }


    
    void ButtonOnClick()
    {
        
    }


    // void OnTriggerEnter2D(Collider2D other)
    // {
    //     if(other.gameObject.CompareTag("Obstacle"))
    //     {
    //         Destroy(gameObject);
    //         SceneManager.LoadScene("DeathScreen");
    //     }
    // }
}
