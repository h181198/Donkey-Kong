using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessBehaviour : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Display victory message
        }
    }
}
