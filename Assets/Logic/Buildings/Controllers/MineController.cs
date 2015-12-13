public class MineController : BaseBuildingController
{
    public MineModel Model { get { return this._buildingModel as MineModel;} }
    protected void Awake() 
    {}

    protected override void Start()
    {
        WarehouseController.Instance.RegisterStorage(Model.name);
    }
}