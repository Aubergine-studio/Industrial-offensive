using System;
using UnityEngine;

[Serializable]
public class BaseModel : ScriptableObject
{
    [SerializeField] public int NumberOfEmployees = 0;
    [SerializeField] public float salary = 1200f;
    [SerializeField] public float workCosts = 100f;
}
    