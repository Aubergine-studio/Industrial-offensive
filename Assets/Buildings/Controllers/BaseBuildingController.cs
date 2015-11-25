using UnityEngine;

public class BaseBuildingController : MonoBehaviour
{

    protected BaseModel _buildingModel;

    public BaseModel BuildingModel {  get { return _buildingModel; } }

    protected virtual void Awake() { }

    protected virtual void Start() { }

    public virtual void Hire(int numberOfNewEmployees)
    {
        _buildingModel.NumberOfEmployees += numberOfNewEmployees;
    }
}
