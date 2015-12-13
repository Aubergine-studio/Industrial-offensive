using System;
using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Buildings models/Mine Model", fileName = "New Mine Model.asset")]
[Serializable]
public class MineModel : BaseModel
{
    [SerializeField]
    protected float miningDepth = 100f;
    [SerializeField]
    protected RawMaterial RawMaterial;
}
