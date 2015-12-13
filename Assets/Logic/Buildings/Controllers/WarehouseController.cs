using UnityEngine;
using System.Collections;

public class WarehouseController : BaseBuildingController
{
    public static WarehouseController Instance { get; private set; }

    public WarehouseModel Model { get { return this._buildingModel as WarehouseModel; } }

    protected override void Awake()
    {
        base.Awake();

        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            GameObject.Destroy(this.gameObject);
        }
    }

    public void RegisterStorage(string rawMaterialName)
    {
        StorageSlot slot = new StorageSlot
        {
            RawMaterialName = rawMaterialName,
            maxCapacity = Model.maxStorageSlotCapacity
        };

        Model.StorageSlots.Add(slot);
    }
}
 