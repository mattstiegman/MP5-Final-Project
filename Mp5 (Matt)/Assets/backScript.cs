using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backScript : MonoBehaviour {

    // Similarly to the "PLAY" button, this functions brings the user back to the Main Menu.
    public void toMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
