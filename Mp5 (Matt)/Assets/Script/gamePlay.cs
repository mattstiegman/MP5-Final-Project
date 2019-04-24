using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamePlay : MonoBehaviour {
    public GameObject arrowPrefab;
    // Joystick Class/Variable that is used instead of the Input.GetAxis call.
    public Joystick joystick;
    private void Update() {
        /**Since we are in the update(), this means everytime the frame will be updated.
        Therefore the Time.deltaTime is necessary for refreshing the frame.

        As mentioned above, the Joystick class is used for movement, because the
        assets have a built in script for detecting onClick and sprite movement.
        **/
        Vector3 horizontal = new Vector3(joystick.Horizontal, 
                                         joystick.Vertical, 0.0f);

        transform.position = transform.position + horizontal * Time.deltaTime * 15;

        // Shooting arrows
        if (Input.GetButtonDown("Fire1")) {
            GameObject arrow = Instantiate(arrowPrefab,
                                          transform.position,
                                          Quaternion.identity);
            arrow.GetComponent<Rigidbody2D>().velocity = new Vector2(60.0f, 0);
        }
    }
}
