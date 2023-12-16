using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 100;
    private void Start()
    {
        
    }
    public void ChangeHealth(int damage)
    {
        health = health - damage;
    }
}
