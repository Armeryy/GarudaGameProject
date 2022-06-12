using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager Instance;

    public bool isCounting = true; 
    private float elapsedTime = 0f;
    
    private int score = 0;

    [SerializeField]
    private TMP_Text scoreText;

    private void Awake() 
{ 
    // If there is an instance, and it's not me, delete myself.
    
    if (Instance != null && Instance != this) 
    { 
      
                Destroy(this); 
    } 
    else 
    { 
        Instance = this; 
    } 
}





    // Start is called before the first frame update
    void Start()
    {
    //    Keep Score text to next scene 
        DontDestroyOnLoad(transform.root);
    }

    // Update is called once per frame
    void Update()
    {
        if (isCounting)
        {
        elapsedTime += Time.deltaTime;
        score = (int)elapsedTime;
        scoreText.text = score.ToString();
        }
    }


    
    void ButtonOnClick()
    {
        
    }


}
