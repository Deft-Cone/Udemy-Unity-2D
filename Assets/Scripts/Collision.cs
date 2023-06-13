using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided with " + collision.collider.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered " + collision.name);
    }
}
