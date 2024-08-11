using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metods : MonoBehaviour
{

    public int health;
    public float damage;
    public int level;
    public int experience;
    public int experienceToNextLevel;

    void Start()
    {
        TakeDamage();
        TakeDamageFloat();
        GainExperience();
        
    }

    //Метод нанесения урона с типом данных int
    public void TakeDamage()
    {
        int damageAmount = 40;
        health = damageAmount--;
        Debug.LogError($"Игрок{health} жизней. Осталось{damageAmount}жизней");
       
    }

    //Метод для нанесения урона с типом данных float

    public void TakeDamageFloat()
    {
        float damageAmount = 35.78f;
        damage = damageAmount--;
        Debug.LogError($"Игрок{damage} damage. Осталось {damageAmount}жизней");
    }

    // Метод для получения опыта
    public void GainExperience()
    {
        int exp = 0;
        experience = exp++;
        Debug.LogError($"Опыт игрока {experience}. Полученный опыт игрока {exp}");
        
    }

    
    void Update()
    {
        
    }
}
