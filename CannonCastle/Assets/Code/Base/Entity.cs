using UnityEngine;
using System.Collections;

public class Entity : CoreBehavior 
{
	public bool AutoRegisterWithManager = false;
	public string EntityID;
	
	public void Start()
	{
		if(AutoRegisterWithManager)
		{
			if(EntityID != "")
			{
				GM.EntityMG.Add(this);
			}
		}
	}
}
