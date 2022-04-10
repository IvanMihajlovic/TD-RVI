using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : MonoBehaviour, IDamageable
{
    public int health;
    public int Health { get { return health; } }

    public RectTransform rTransform;

    public void Die()
    {
        Destroy(gameObject);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Die();
        }
    }

    public void SetHealth(int healthToBeSet)
    {
        health = healthToBeSet;
    }
}
