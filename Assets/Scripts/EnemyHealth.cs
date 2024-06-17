using System;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int maxHP = 5;

    private int currentHP = 0;
    void Start()
    {
        currentHP = maxHP;
    }

    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        currentHP--;

        if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
