using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayNow()
    {
        SceneManager.LoadScene(1);
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }
}
