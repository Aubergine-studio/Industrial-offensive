using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class WarehouseView : BaseView
{
    [SerializeField] private GameObject container;
    [SerializeField] private GameObject warehauseLabel;
    private Dictionary<string, WarehouseDisplayLlabel> WarehouseDisplayLabels = new Dictionary<string, WarehouseDisplayLlabel>(); 

    public WarehouseController Controller { get { return this._buildingController as WarehouseController;} }

    private void Awake()
    {
        WarehouseDisplayLabels.Add("Carbon", new WarehouseDisplayLlabel(warehauseLabel));
        WarehouseDisplayLabels["Carbon"].DisplayLlabelObject.transform.SetParent(container.transform);
        WarehouseDisplayLabels["Carbon"].DisplayLlabelObject.transform.localScale = Vector3.one;
    }

    private void Start()
    {
        _buildingController = WarehouseController.Instance.RregisterView(this);
    }

    private void Update()
    {
        foreach (StorageSlot slot in Controller.StorageSlots)
        {
            WarehouseDisplayLabels[slot.RawMaterialName].LabelUpdate(slot.collected, slot.maxCapacity);
        }
    }
}

public class WarehouseDisplayLlabel
{
    public GameObject DisplayLlabelObject;
    private Text label;

    public WarehouseDisplayLlabel(GameObject warehauseLabel)
    {
        DisplayLlabelObject = GameObject.Instantiate(warehauseLabel);
        label = DisplayLlabelObject.GetComponent<Text>();
    }

    public void LabelUpdate(float c, float m)
    {
        label.text = c.ToString() + "/" + m.ToString();
    }
}