using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    private GameObject highScore;

    public void PlayGame()

    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadSceneAsync("SampleScene");
    }



    public void QuitGame()
    {
    Debug.Log("Quit");
    Application.Quit();
    }

    public void ShowTheHighScore()
    {
        highScore = GameObject.FindGameObjectWithTag("Text");

        if (highScore.GetComponent<Text>().isActiveAndEnabled == false) {
            highScore = GameObject.FindGameObjectWithTag("Text");
            highScore.GetComponent<Text>().enabled = true;
        }
        else
        {
            highScore.GetComponent<Text>().enabled = false;
        }
        
    }
    
}
