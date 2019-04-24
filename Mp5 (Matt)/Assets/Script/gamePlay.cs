using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamePlay : MonoBehaviour {
    public GameObject arrowPrefab;

    private void Update() {
        /**Since we are in the update(), this means everytime the frame will be updated.
        Therefore the Time.deltaTime is necessary for refreshing the frame. 
        **/
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 
                                         Input.GetAxis("Vertical"), 0.0f);

        transform.position = transform.position + horizontal * Time.deltaTime * 15;

    }
}
