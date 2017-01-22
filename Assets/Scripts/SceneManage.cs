using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{	
	public void StartGame()
    {
        print("navi to start");
        SceneManager.LoadScene("InputTest");
    }

    public void GameOver()
    {
        print("navi to game");
        SceneManager.LoadScene("Credits");
    }

    public void MainMenu()
    {
        print("navi to main");
        SceneManager.LoadScene("Menu");
    }
}
