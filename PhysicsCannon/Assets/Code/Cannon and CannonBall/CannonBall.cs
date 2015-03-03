using UnityEngine;
using System.Collections;

public class CannonBall : CoreBehavior 
{
	public float LifeTime = 3.0f;
	
	// Update is called once per frame
	void Update () 
	{
		LifeTime -= Time.deltaTime;
		
		if(LifeTime <= 0.0f)
		{
			Die();
		}
	}
}
