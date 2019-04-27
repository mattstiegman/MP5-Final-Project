using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject target;
    float moveSpeed;
    Vector3 direction;
    void Start()
    {
        //When the object is created, its target is set to the player and given a random move speed.
        target = GameObject.Find("Player");
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = Random.Range(4f, 8f);
    }

    
    void Update()
    {
        //Enemies are moved every update.
        MoveEnemy();
    }
    void MoveEnemy()
    {
        if (target != null)
        {
            //The object and Rigibody are moved in the direction of the player from the enemies current position.
            direction = (target.transform.position - transform.position).normalized;
            rb.velocity = new Vector2(direction.x * moveSpeed,
                direction.y * moveSpeed);
        }
        //If the player dies, enemies stop moving.
        else
            rb.velocity = Vector3.zero;
    }
}
