using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public ScoreManager scoreManager;

    // [SerializeField]
    // public PauseMenu pauseMenu; 

    [SerializeField]
    public Rigidbody2D rb;

    public float moveSpeed = 5;

    public float moveDirection = 0;

    public static bool isPaused;

    

    // public void ButtonLeft()
    // {
    //     Debug.Log("Left");
    //     rb.velocity = new Vector2(-moveSpeed,0);
    // }
    
   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        // Debug.Log("a");
        // Debug.Log(Input.touchCount);
        if (Input.touchCount > 0)
        {
        
            Touch touch = Input.GetTouch(0);
            Vector2 pos = touch.position;
        }

        float moveDirection = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveDirection * moveSpeed,0);

     

    }

    // void DestroyPauseMenu()
    // {
    //     if (GameObject.Find("PauseMenu") != null)
    //     {
    //         PauseMenu.Instance = null;
    //         Destroy(GameObject.Find("PauseMenu"));
    //     }
    // }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Obstacle"))
        {
            // DestroyPauseMenu();
            Destroy(gameObject);
            scoreManager.isCounting = false;
            SceneManager.LoadScene("DeathScreen");
            
        }
    }

}


