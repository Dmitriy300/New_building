using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int Health;
    public bool IsDeath;

    private void Update()
    {
        IsDeath = Health <= 0 ? true : false;
        
        if (Health == 0)
        {
           gameObject.SetActive(false);
           TakeDamage(Health);
        }
    }
    public void SetActive(bool isActive)
    {
        gameObject.SetActive(isActive);
    }

    public void TakeDamage(int damage)
    {
        if (IsDeath)
            return;

        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }
        Debug.LogError(" is dead.");
        
    }

   
}

