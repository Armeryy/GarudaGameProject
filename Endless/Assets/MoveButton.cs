using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButton : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed = 5;
    public float moveDirection = 0;
    public Rigidbody2D rb;

    

    void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();

    }


    void OnButtonDownLeft()
    {
        // Debug.Log("a");
        rb.velocity = new Vector2(-moveSpeed,0);
    }

    void OnButtonDownRight()
    {
        player.transform.Translate(moveDirection * moveSpeed, 0, 0);

    }
    
    


}
