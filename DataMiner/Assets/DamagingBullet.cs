using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DamagingBullet : MonoBehaviour
{
    public int damage;
    public int collectedInfo;
    public int collectedLoc;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<CollisionDetection>(out CollisionDetection tile))
        {
            tile.TakeDamage(damage);
            if (collision.gameObject.CompareTag("InformationBit"))
            {
                collectedInfo += 1;
            }
            if (collision.gameObject.CompareTag("LocationBit"))
            {
                collectedLoc += 1;
            }
        }
        Destroy(gameObject);
    }
}
