using UnityEngine;
using System.Collections;

public class WarehouseView : BaseView
{
    [SerializeField] private GameObject container;
    [SerializeField] private GameObject warehauseLabel;

    public WarehouseController Controller { get { return this._buildingController as WarehouseController;} }
    
    private void Start()
    {
        _buildingController = WarehouseController.Instance.RregisterView(this);
    }
}
