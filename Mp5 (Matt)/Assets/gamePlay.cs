using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamePlay : MonoBehaviour
{
    public void backtoMenu()
    {
        SceneManager.LoadScene(0);
    }
}
