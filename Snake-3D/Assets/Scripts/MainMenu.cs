using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace SnakeGame { 

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadSceneAsync(0);

    }
	public bool PlayGameForTest()
		{
			SceneManager.LoadSceneAsync(0);
			return true;

		}

	public void QuitGame(){
        Application.Quit();
    }
	public bool QuitGameForTest()
		{
			Application.Quit();
			return true;

		}
	}
}
