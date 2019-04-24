using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

    /** Equipeed to the "PLAY" button in Main Menu. Takes the user to
       the actual game. **/
    public void gamePlay ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }
    // Equipped to the "YES" button in Quit Confirm Menu. Closes the app.
    public void gameQuit()
    {
        Debug.Log("closed app");
        Application.Quit();
    }
}
