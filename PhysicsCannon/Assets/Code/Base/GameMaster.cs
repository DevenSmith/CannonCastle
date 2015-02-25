using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour
{

	public EntityManager EntityMG;
	
	public SettingsManager SettingsMG;
	
	static GameMaster gm;
	
	
	public void Awake()
	{
		if(gm == null)
		{
			gm = this;
		}
	}
	
	public static GameMaster Instance
	{
		get{return gm;}
	}
	
}
