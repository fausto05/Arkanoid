using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int lives = 3;

    public void lossHealt()
    {
        lives--;
        
        if (lives <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            ResetLevel();
        }
    }

    public void ResetLevel()
    {
        FindObjectOfType<Ball>().ResetBall();
        FindObjectOfType<Player>().ResetPlayer();
    }

    private void Update()
    {
        CheckBricks();
    }

    void CheckBricks()
    {
        GameObject[] bricks = GameObject.FindGameObjectsWithTag("Brick");

        if (bricks.Length == 0)
        {
            SceneManager.LoadScene("Win");  
        }
    }
}




