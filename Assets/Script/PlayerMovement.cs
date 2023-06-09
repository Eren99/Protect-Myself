using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /*public float playerSpeed;
    public Rigidbody2D rb;
    public Vector2 playerDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }*/

    public float playerJump;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        BirdMovement();
    }

    void BirdMovement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(rb.velocity.x, playerJump);
        }
    }

}