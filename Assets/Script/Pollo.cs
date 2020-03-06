using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pollo : MonoBehaviour
{
     
    private Rigidbody2D myRB;

    //Para establecer un rango de valores
    [Range(3,8)] 
    public float speed = 5f;
    public Text scoreText;
    public Text highScoreText;
    private Rigidbody2D myRigidbody2D;
    private int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();

        int highScore = PlayerPrefs.GetInt("score");
        highScoreText.text = highScore + "";
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRB.velocity = Vector2.up * speed; // ---> (0,1) * 5

        }
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (PlayerPrefs.GetInt("score") < score)
        {
            PlayerPrefs.SetInt("score", score);
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        scoreText.text = "" + score;
    }
}
