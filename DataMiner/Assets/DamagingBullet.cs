using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagingBullet : MonoBehaviour
{
    public float damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.TryGetComponent<TakingDamage>(out TakingDamage enemy))
        {
            enemy.TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}
