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

    //����� ��������� ����� � ����� ������ int
    public void TakeDamage()
    {
        int damageAmount = 40;
        health = damageAmount--;
        Debug.LogError($"�����{health} ������. ��������{damageAmount}������");
       
    }

    //����� ��� ��������� ����� � ����� ������ float

    public void TakeDamageFloat()
    {
        float damageAmount = 35.78f;
        damage = damageAmount--;
        Debug.LogError($"�����{damage} damage. �������� {damageAmount}������");
    }

    // ����� ��� ��������� �����
    public void GainExperience()
    {
        int exp = 0;
        experience = exp++;
        Debug.LogError($"���� ������ {experience}. ���������� ���� ������ {exp}");
        
    }

    
    void Update()
    {
        
    }
}
