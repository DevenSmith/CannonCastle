using UnityEngine;
using System.Collections;

public class CoreBehavior : MonoBehaviour 
{
	public GameMaster GM
	{
		get {return GameMaster.Instance;}
	}
	
	public void Die()
	{
		Entity e = gameObject.GetComponent<Entity>();
		if(e != null)
		{
			GM.EntityMG.Remove(e);
		}
	
		Destroy(gameObject);
		
	}
}
