using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CircleFollowing : MonoBehaviour
{

	public float mass = 1.0f;
	public float maxSpeed = 5.0f;

	public Vector3 velocity;
	public Vector3 force;

	public int currentWaypoint;
	public int lastWaypoint;

	public List<Vector3> wayPoints = new List<Vector3>();

	private void CreatePath(int points, float radius)
	{
		wayPoints.Clear();

		float thetaInc = (2*Mathf.PI)/points;
		for(int point = 0; point < points; point ++)
		{
			float lastX = 0;
			float lastY = radius;
			float theta = (thetaInc * point)/2;
			//wayPoints.x = Mathf.Sin(theta) * radius;
			//wayPoints.z = - Mathf.Cos(theta) * radius;

		}	
	}

	private void DrawPath()
	{
		for(i = 1; i < wayPoints.Count(); i ++)
		{
			Debug.DrawLine(wayPoints[i - 1], wayPoints[i], Color.red);
		}
	}

	Vector3 Seek(Vector3 point)
	{
		Vector3 desired = point - transform.position;
		desired.Normalize();
		desired *= maxSpeed;
		return(desired - velocity);
	}

	Vector3 FollowPath()
	{
		Vector3 toCurrent = wayPoints[currentWaypoint] - transform.position;
		float distanceToCurrent = toCurrent.magnitude;

	}

	// Use this for initialization
	void Start ()
	{
		CreatePath(10,10.0f);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
