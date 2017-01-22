using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{	
	public void StartGame() { SceneManager.LoadScene("InputTest");}
    public void GameOver() { SceneManager.LoadScene("Credits"); }
    public void MainMenu() { SceneManager.LoadScene("Menu"); }
}
