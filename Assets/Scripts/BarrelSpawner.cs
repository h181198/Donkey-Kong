using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelSpawner : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public GameObject barrel;
    public float odds = 0.9F;
    public float spawnInterval = 1.0F;

    private float spawnTime = 1.0F;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Time.time > spawnTime)
        {
            float random = Random.Range(0.0F, 1.0F);
            if (random > odds)
            {
                Instantiate(barrel, _rigidbody.position, Quaternion.identity);
            }

            spawnTime += spawnInterval;
        }
    }
}
