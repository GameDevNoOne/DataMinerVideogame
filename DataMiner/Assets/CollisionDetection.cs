using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CollisionDetection : MonoBehaviour
{
    public int Health;
    public bool isLocDestroyed;
    public bool isInfoDestroyed;

    public void Start()
    {
        isLocDestroyed = false;
        isInfoDestroyed = false;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            if (gameObject.CompareTag("InformationBit")) 
            {
                isInfoDestroyed = true;
                Invoke("DestroyBit", 0.5f);
            }
            if (gameObject.CompareTag("LocationBit"))
            {
                isLocDestroyed = true;
                Invoke("DestroyBit", 0.5f);
            }
            Invoke("DestroyBit", 0.1f);
        }
    }

    public void DestroyBit()
    {
        Destroy(gameObject);
    }
}
