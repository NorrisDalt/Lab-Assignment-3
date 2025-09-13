using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public float thrust = 1.0f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Rigidbody2D rb = other.attachedRigidbody;
        if(rb != null )
        {
            Vector2 direction = other.transform.position - transform.position;

            Vector2 force = -direction.normalized * thrust;

            rb.AddForce(direction * thrust, ForceMode2D.Impulse);
        }
    }
}
