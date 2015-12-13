using System;
using UnityEngine;
using System.Collections;

[Serializable]
public class Timer : MonoBehaviour
{

    [SerializeField] private TimeInterval interval = new TimeInterval();
    private float millisecondsInInterval = 0;
    private float millisecondsCounter = 0;

    public Action OnClik; 

	private void Awake()
	{
	    millisecondsInInterval = interval.GetMilliseconds();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    float time = Time.deltaTime * 1000f;

	    millisecondsCounter += time;

	    if (millisecondsInInterval <= millisecondsCounter)
	    {
	        millisecondsCounter = 0;
	        if (OnClik != null)
	        {
	            OnClik();
	        }
	        Debug.Log("Pow!");
	    }
	}
}

[Serializable]
public struct TimeInterval
{
    [SerializeField] private float hours;
    [SerializeField] private float minutes;
    [SerializeField] private float seckends;

    public float Hours
    {
        get { return hours; }
        set { hours = value; }
    }

    public float Minutes
    {
        get { return minutes; }
        set { minutes = value; }
    }

    public float Seckends
    {
        get { return seckends; }
        set { seckends = value; }
    }

    public float GetMilliseconds()
    {
        float minutes = this.minutes + (hours*60);
        float seckends = this.seckends + (minutes*60);

        return seckends*1000;
    }
}