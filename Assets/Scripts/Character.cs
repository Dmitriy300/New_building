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
        if (IsDeath)
        {

        }

        
    }
    public void SetActive(bool isActive)
    {
        gameObject.SetActive(isActive);
    }

}
