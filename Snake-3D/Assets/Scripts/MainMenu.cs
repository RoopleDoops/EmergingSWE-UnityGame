using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace SnakeGame { 
public class MainMenu : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            PlayGame();
        }
    }

    public void PlayGame(){
        SceneManager.LoadSceneAsync(1);
    }

    public void QuitGame(){
        Application.Quit();
    }

	public bool GameStatusScreen()
	{
        return true;
	}
}
}