using UnityEngine;
using System.Collections;

public class Damageable : CoreBehavior 
{
	public float DesctructionForce = 1000.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision c)
	{
		//check if the impact was strong enough to destroy the object and handle that based on the object
	}
}
