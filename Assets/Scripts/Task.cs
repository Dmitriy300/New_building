using System;
using UnityEngine;


public class Task : MonoBehaviour
{

    private void Start()
    {
        TypesVariables();
       
    }

    public void TypesVariables()
    {
        int IntegerVariable = 1;
        float FloatingPointVariable = 6.34984898995003100958845893034675873722685858f;
        bool LogicalVariable = false;

        Debug.LogWarning($"����� ����� {IntegerVariable}");
        Debug.LogError($"����� � ��������� ������ {FloatingPointVariable}");
        Debug.LogWarning($"���������� ���������� {LogicalVariable}");
    }

   
    private void Update()
    {
        
    }

    private void OnValidate()
    {
        
        
    }
}
 