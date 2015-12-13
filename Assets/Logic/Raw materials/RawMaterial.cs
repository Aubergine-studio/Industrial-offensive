using System;
using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Raw Material ", fileName = "New Raw Material.asset")]
[Serializable]
public class RawMaterial : ScriptableObject
{
    [SerializeField] public string Name = string.Empty;
    [SerializeField] public float Price; 
}
