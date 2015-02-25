using UnityEngine;
using System.Collections;

public class CoreBehavior : MonoBehaviour 
{
	public GameMaster GM
	{
		get {return GameMaster.Instance;}
	}
}
