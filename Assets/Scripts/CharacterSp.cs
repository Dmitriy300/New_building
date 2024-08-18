using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSp : MonoBehaviour
{
    public Character Character;
    public Transform Point;
    
    

    private void Start()
    {
        Instantiate(Character, Point.position, Quaternion.identity);

        for (int i = 0; i < 5; i++)
        {
            Character instantiate = Instantiate(Character, new Vector3(i, 0, 0), Quaternion.identity);

            

        }
    }
}
