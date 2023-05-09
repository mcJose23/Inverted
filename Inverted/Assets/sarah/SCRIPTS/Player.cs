using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;
    private Rigidbody2D rb;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkDistance;
    public LayerMask groundMask;

    private bool isWalled;
    public Transform wallCheck;
    public float wallDistance;

    private int extraJumps = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkDistance, groundMask);
        isWalled = Phyics2D.OverlapCircle(wallCheck.position, wallDistance, groundMask);


    } 
}
