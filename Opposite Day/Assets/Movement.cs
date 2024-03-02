using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private float Move;
    private Rigidbody2D rb;
    public float JumpHeight;
    bool Grounded;
    public Transform GroundCheck;
    public LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(Move * speed, rb.velocity.y);

        Grounded = Physics2D.OverlapCircle(GroundCheck.position, .25f, groundLayer);

        if(Input.GetButtonDown("Jump") && Grounded)
        {
            rb.AddForce(new Vector2(rb.velocity.x, JumpHeight));
        }
    }
}
