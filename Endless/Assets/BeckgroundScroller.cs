using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeckgroundScroller : MonoBehaviour
{
    
    public BoxCollider2D colliderr;

    public Rigidbody2D rb;

    private float height;
    [SerializeField]
    private float scrollSpeed = -5f;
    
    private float elapsedTime = 0f;
    

    // Start is called before the first frame update
    void Start()
    {
        colliderr = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        height = colliderr.size.x;
        colliderr.enabled = false;

        rb.velocity = new Vector2(0,scrollSpeed);
        ResetObstacle();
    
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -height)
        {
            Vector3 resetPosition = new Vector3(0,height * 2f,0);
            transform.position = transform.position + resetPosition;
            ResetObstacle();

        }
        elapsedTime += Time.deltaTime;

        rb.velocity = new Vector2(0,scrollSpeed - elapsedTime);

    }

    void ResetObstacle()
    {
        transform.GetChild(0).localPosition = new Vector3(Random.Range(4,8), Random.Range(-2,2), 0);
    }
}
