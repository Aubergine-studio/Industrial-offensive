using System;
using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Buildings models/Mine Model", fileName = "New Mine Model.asset")]
[Serializable]
public class MineModel : BaseModel
{
    [SerializeField] public float miningDepth = 100f;
    [SerializeField] public float productionPerSecondPerEmploye = 10f;
    [SerializeField] public RawMaterial RawMaterial;
}
