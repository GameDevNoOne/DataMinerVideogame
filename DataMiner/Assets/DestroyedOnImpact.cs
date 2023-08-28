using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyedOnImpact : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
