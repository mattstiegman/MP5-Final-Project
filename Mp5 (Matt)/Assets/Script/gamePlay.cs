using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamePlay : MonoBehaviour
{
    private void Update()
    {
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 
            Input.GetAxis("Vertical"), 0.0f);
        /**Since we are in the update(), this means everytime the frame will be updated.
        Therefore the Time.deltaTime is necessary for refreshing the frame. 
        **/
        transform.position = transform.position + horizontal * Time.deltaTime;

    }
}
