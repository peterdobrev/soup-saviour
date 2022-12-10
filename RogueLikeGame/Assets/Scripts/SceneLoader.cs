using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
       
    }


    public void StartTheGame()
    {
        ScoreCounter.score = 0;
        SceneManager.LoadScene("SampleScene");
    }

    public void ReturnToMainMenu()
    {
        ScoreCounter.score = 0;
        SceneManager.LoadScene("Menu");
    }

    public void DoExitGame()
    {
        Debug.Log("Game is exiting");
        Application.Quit();
       
    }


}
