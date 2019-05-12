using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private SpriteRenderer _renderer;

    public float moveSpeed = 10;
    public float jumpHeight = 170;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _renderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        float movement = Input.GetAxisRaw("Horizontal");

        _rigidbody.velocity = new Vector2(movement * moveSpeed, _rigidbody.velocity.y);
        if(movement.Equals(-1)) {
            _renderer.flipX = true;
        } else if (movement.Equals(1))
        {
            _renderer.flipX = false;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        float jump = Input.GetAxisRaw("Jump");
        string collisionTag = collision.gameObject.tag;
        if (jump > 0 && (collisionTag == "Platform" || collisionTag == "TopPlatform"))
        {
            _rigidbody.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ladder")
        {
            float vertical = Input.GetAxis("Vertical");
            _rigidbody.velocity = new Vector2(0, vertical) * moveSpeed;
        }
    }
}
