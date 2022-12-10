using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    
    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Launch(Vector2 direction, float force)
    {
        rigidbody2D.AddForce(direction * force);
    }

    void Update()
    {
        if (transform.position.magnitude > 1000f)
        {
            Destroy(gameObject);
        }
    }

    void OnCillisionEntter2D(Collision2D other)
    {
        EnemyController e = other.collider.GetComponent<EnemyController>();
        if(e != null)
        {
            e.Fix();
        }

        Destroy(gameObject);
    }

    
}