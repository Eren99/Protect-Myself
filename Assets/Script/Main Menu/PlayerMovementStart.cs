using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovementStart : MonoBehaviour
{
    //public Rigidbody2D rb;
    public float maxY;
    public float minY;
    public float speed;
    private Vector3 targetPosition;
    
    private void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        targetPosition = transform.position;
    }

    private void Update()
    {
        MoveMent();
    }

    void MoveMent()
    {
        if (transform.position.y <= minY) 
        {
            targetPosition = new Vector3(transform.position.x, maxY, transform.position.z);
        }

        else if (transform.position.y >= maxY)
        {
            targetPosition = new Vector3(transform.position.x, minY);
            speed = speed * -1;
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
}
