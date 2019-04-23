using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

    public void gamePlay ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
        //after clicking play, this will go to the gameplay.
    }
    public void gameQuit()
    {
        Debug.Log("closed app");
        Application.Quit();
        // quick the app
    }
}
