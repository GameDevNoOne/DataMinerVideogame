using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakingDamage : MonoBehaviour
{
    public float Health;

    public void TakeDamage(float damage)
    {
        Health -= damage;

        if (Health <= 0 )
        {
            Destroy(gameObject);
        }
    }
}
