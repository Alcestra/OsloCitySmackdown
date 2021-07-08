using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float movementSpeed = 5;
    private Rigidbody2D rb2D;
    Vector2 movement;

    public Animator playerAnim;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        // movement
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        //Movement Animations
        playerAnim.SetFloat("Horizontal", movement.x);
        playerAnim.SetFloat("Vertical", movement.y);
        playerAnim.SetFloat("Speed", movement.sqrMagnitude);


        //combat
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
            Debug.Log("Attacking");
        }

    }

   void Attack()
    {

        playerAnim.SetTrigger("Attack");

    }

    private void FixedUpdate()
    {

        //Movement
        rb2D.MovePosition(rb2D.position + movement * movementSpeed * Time.fixedDeltaTime);

    }


    
}
