using System.Collections;
using System.Collections.Generic;

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

        if (bricks.Length == 0) // Si no quedan ladrillos
        {
            // Verificar en qué nivel estamos
            string currentSceneName = SceneManager.GetActiveScene().name;

            if (currentSceneName == "SampleScene")
            {
                SceneManager.LoadScene("Level2"); // Cargar Nivel 2 si estamos en el Nivel 1
            }
            else if (currentSceneName == "Level2")
            {
                SceneManager.LoadScene("Win"); // Cargar pantalla de victoria si estamos en el Nivel 2
            }
        }
    }

    
}




