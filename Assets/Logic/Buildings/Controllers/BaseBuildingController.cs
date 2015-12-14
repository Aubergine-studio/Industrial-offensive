using UnityEngine;

public class BaseBuildingController : MonoBehaviour
{

    [SerializeField] protected BaseModel _buildingModel;
    [SerializeField] protected BaseView _BuildingView;

    [SerializeField] protected Timer BuildingTimer;

    public BaseModel BuildingModel { get { return _buildingModel; } }
    public BaseView BuildingView { get { return _BuildingView; } }

    protected virtual void Awake()
    {
        BuildingTimer = GetComponent<Timer>();
        BuildingTimer.OnClik += OnTimerTick;
    }
    protected virtual void Start() { }

    public virtual void Hire(int numberOfNewEmployees)
    {
        _buildingModel.NumberOfEmployees += numberOfNewEmployees;
    }

    protected virtual void Update() { }

    protected virtual void OnDestroy()
    {
        if (BuildingTimer != null && BuildingTimer.OnClik != null)
        {
            BuildingTimer.OnClik -= OnTimerTick;
        }
    }

    public virtual BaseBuildingController RregisterView(BaseView view) { return this; }
    protected virtual void OnTimerTick() { }
}
