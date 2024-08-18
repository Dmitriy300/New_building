using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int Health;
    public bool IsDeath;
    public bool isAlly;
    public bool isEnemy;

    
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
        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }
        Debug.LogError(" is dead.");
        
    }
    
    private Renderer characterRenderer;

    private void Start()
    {
        characterRenderer = GetComponent<Renderer>();
        UpdateColor();


    }

    public void UpdateColor()
    {
        // Меняем цвет в зависимости от команды персонажа
        if (isAlly)
        {
            characterRenderer.material.color = Color.red;
        }
        else if (isEnemy)
        {
            characterRenderer.material.color = Color.blue;
        }
    }
}

