using UnityEngine;

public class MineController : BaseBuildingController
{
    public MineModel Model { get { return this._buildingModel as MineModel; } }
    protected StorageSlot Slot;

    protected override void Start()
    {
        Slot = WarehouseController.Instance.RegisterStorage(Model.RawMaterial.Name);
    }

    protected override void OnTimerTick()
    {
        if (Slot.maxCapacity > Slot.collected)
        {
            Slot.collected += Model.productionPerSecondPerEmploye * 
                Model.NumberOfEmployees * 
                Model.RawMaterial.Price;
        }
    }
}