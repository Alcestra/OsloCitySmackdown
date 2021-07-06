using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float playerSpeed;
    private Rigidbody2D rb2D;

    Vector2 movement;
   
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
   
    }

    private void FixedUpdate()
    {

        //Movement
        rb2D.MovePosition(rb2D.position + movement * playerSpeed * Time.fixedDeltaTime);

    }
}
