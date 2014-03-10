using UnityEngine;
using System.Collections;

public class CubeArrive : MonoBehaviour {

	public Vector3 velocity;
	public Vector3 force;

	public float maxSpeed = 5.0f;
	public float mass = 1.0f;

	public Vector3 target;

	Vector3 ArriveAtTarget()
	{
		float slowingRange = 10.0f;
		Vector3 toTarget = target - transform.position;
		float distanceToTarget = toTarget.magnitude;
		if (distanceToTarget < 1)
		{
			target = Random.insideUnitCircle*Random.Range(0,9);
		}
			toTarget.Normalize();
			toTarget *= maxSpeed;
			return(desired - velocity);
	}

	// Use this for initialization
	void Start ()
	{
		target = Random.insideUnitCircle*Random.Range(0,9);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
