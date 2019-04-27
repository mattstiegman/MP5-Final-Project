using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamePlay : MonoBehaviour {

    public GameObject arrowPrefab; // prefab of the arrow.
    public GameObject crossHair; // objecet of crosshair.
    public GameObject gameOver, restartButton, menuButton;
    float fireRate = 0.5f;
    float lastShot = 0f;

    private void Start()
    {
        gameOver.SetActive(false);
        restartButton.SetActive(false);
        menuButton.SetActive(false);
    }


    // Joystick Class/Variable that is used instead of the Input.GetAxis call.
    public Joystick joystickMovement; // this controls character's movement.
    public Joystick joystickAim; // this controls the character's aim.


    private void Update() {
        /**Since we are in the update(), this means everytime the frame will be updated.
        Therefore the Time.deltaTime is necessary for refreshing the frame.

        As mentioned above, the Joystick class is used for movement, because the
        assets have a built in script for detecting onClick and sprite movement.
        **/
        Vector3 horizontal = new Vector3(joystickMovement.Horizontal,
                                         joystickMovement.Vertical, 0.0f);
        transform.position = transform.position + horizontal * Time.deltaTime * 15;

        // Aiming and shooting arrows.
        aimAndShoot();
    }
    private void aimAndShoot() {
        Vector3 aim = new Vector3(joystickAim.Horizontal, joystickAim.Vertical, 0.0f);
        Vector2 shootingDirection = new Vector2(joystickAim.Horizontal, joystickAim.Vertical);
        GameObject arrow; 
        if (aim.magnitude > 0.0f)
        {   //normalize the vector 1 unit long. 
            //That being said, the crosshair can only be 1 unit away from the player.
            aim.Normalize();
            aim *= 5.0f; //increase the distance between the player and the crosshair.
            crossHair.transform.localPosition = aim;
            crossHair.SetActive(true);
            if (aim.magnitude > 0.0f) {
                if (Time.time > fireRate + lastShot) {
                    arrow = Instantiate(arrowPrefab, transform.position, Quaternion.identity);
                    arrow.GetComponent<Rigidbody2D>().velocity = shootingDirection * 30;
                    //The arrow.transform.rotate rotates the direction of arrows in accordance to the crosshair. 
                    arrow.transform.Rotate(0.0f, 0.0f, Mathf.Atan2(shootingDirection.y, shootingDirection.x) * Mathf.Rad2Deg);
                    //Destory() will destory the arrows in two seconds.
                    Destroy(arrow, 2.0f);
                    lastShot = Time.time;
                }
            }
        } else {
            //if player didn't move the crosshair, the crosshair will disappear.
            crossHair.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Brings up Game over screen and kills player on contact with an enemy.
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            EnemyMovement.moveSpeed = 0.0f;
            EnemySpawner.spawnAllowed = false;
            gameOver.SetActive(true);
            restartButton.SetActive(true);
            menuButton.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
