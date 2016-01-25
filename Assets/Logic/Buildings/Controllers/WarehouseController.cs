using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class WarehouseController : BaseBuildingController
{
    public static WarehouseController Instance { get; private set; }

    public WarehouseModel Model { get { return this._buildingModel as WarehouseModel; } }
    public List<StorageSlot> StorageSlots { get { return this.Model.StorageSlots; } } 
    public WarehouseView View { get { return this._BuildingView as WarehouseView;} }

    protected override void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            Model.StorageSlots.Clear();
        }
        else
        {
            GameObject.Destroy(this.gameObject);
        }
    }

    public override BaseBuildingController RregisterView(BaseView view)
    {
        if (_BuildingView == null && view is WarehouseView)
        {
            _BuildingView = view;
        }

        return base.RregisterView(view);
    }

    public StorageSlot RegisterStorage(string rawMaterialName)
    {
        StorageSlot slot = 
        Model.StorageSlots.SingleOrDefault(m => m.RawMaterialName == rawMaterialName) ?? new StorageSlot
        {
            RawMaterialName = rawMaterialName,
            maxCapacity = Model.maxStorageSlotCapacity
        };

        Model.StorageSlots.Add(slot);

        return slot;
    }
}
 