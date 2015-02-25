using UnityEngine;
using System.Collections;

public class CannonControls : CoreBehavior 
{
	public float AngleRotationPerSecond = 10.0f;
	public GameObject CannonBall;
	public Transform FirePoint;
	public float FirePowerMax = 100.0f;
	public float FirePowerPercent = 0.5f;
	public float FirePowerPerSecond = .1f;
	public Transform PivotPoint;
	
	
	int shotsFired = 0;
	
	// Update is called once per frame
	void Update () 
	{
		CannonMovement();
		CannonPowerAdjust();
		FireCannon();
		
	}
	
	public void SetFirePowerPercent(float newFirePower)
	{
		FirePowerPercent = Mathf.Clamp(newFirePower, 0.0f, 1.0f);
	}

	void CannonMovement()
	{
		if(Input.GetKey(GM.SettingsMG.AngleCannonUp))
		{
			PivotPoint.RotateAround(PivotPoint.transform.position, PivotPoint.transform.right, -AngleRotationPerSecond * Time.deltaTime);
		}
		if(Input.GetKey(GM.SettingsMG.AngleCannonDown))
		{
			PivotPoint.RotateAround(PivotPoint.transform.position, PivotPoint.transform.right, AngleRotationPerSecond * Time.deltaTime);
		}
	}
	
	void CannonPowerAdjust()
	{
		if(Input.GetKey(GM.SettingsMG.PowerIncrease))
		{	
			SetFirePowerPercent(FirePowerPercent + FirePowerPerSecond * Time.deltaTime);
		}
		
		if(Input.GetKey(GM.SettingsMG.PowerDecrease))
		{	
			SetFirePowerPercent(FirePowerPercent - FirePowerPerSecond * Time.deltaTime);
		}
	}
	
	void FireCannon()
	{
		if(Input.GetKeyDown(GM.SettingsMG.Fire))
		{
			shotsFired++;
			GameObject cb = (GameObject) Instantiate(CannonBall, FirePoint.position, FirePoint.rotation);
			Entity e = cb.GetComponent<Entity>();
			e.EntityID = "CannonBall " + shotsFired;
			cb.rigidbody.AddForce(FirePoint.forward * (FirePowerPercent * FirePowerMax), ForceMode.Impulse);
		}
	}
}
