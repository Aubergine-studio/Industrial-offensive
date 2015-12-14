using UnityEngine;

public class MineController : BaseBuildingController
{
    public MineModel Model { get { return this._buildingModel as MineModel; } }
    protected StorageSlot Slot;

    protected override void Start()
    {
        Slot = WarehouseController.Instance.RegisterStorage(Model.name);
    }

    protected override void OnTimerTick()
    {
        if (Slot.maxCapacity > Slot.collected)
        {
            Slot.collected += Model.productionPerSecondPerEmploye * Model.NumberOfEmployees;
        }

        Debug.ClearDeveloperConsole();
        Debug.Log(gameObject.name + ": " + Model.RawMaterial.Name + ": " + Slot.maxCapacity + "/" + Slot.collected);
    }
}