using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelBehaviour : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float initialVelocity = 15;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.velocity = new Vector2(initialVelocity, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x * -1.4F, 0);
        } else if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }
}
