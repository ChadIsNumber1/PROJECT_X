using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float curHealth = 0;
    [SerializeField] private float maxHealth = 100;
    private void Start()
    {
        
    }

    private void Awake()
    {
        curHealth = maxHealth;
    }
    public void ChangeHealth(float damage)
    {
        curHealth = curHealth - damage;
    }

    public float GetCurHealth()
    {
        return curHealth;
    }

    public float GetMaxHealth()
    {
        return maxHealth;
    }

    public float GetHealthRatio()
    {
        return curHealth / maxHealth;
    }
}
