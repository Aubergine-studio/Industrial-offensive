using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Buildings models/Warehouse Model", fileName = "New Warehouse Model.asset")]
[Serializable]
public class WarehouseModel : BaseModel
{
    public int maxStorageSlots = 5;
    public float maxStorageSlotCapacity = 1000f; 
    public List<StorageSlot> StorageSlots = new List<StorageSlot>();
}

[Serializable]
public class StorageSlot
{
    public string RawMaterialName = String.Empty;
    public float collected = 0f;
    public float maxCapacity = 0f;
}
