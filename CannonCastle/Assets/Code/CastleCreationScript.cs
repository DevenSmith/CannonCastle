using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//used for creating the castle Bricks will be kept at a dimension of 1x1x1 for now
public class CastleArray
{
	public GameObject[] Elements;
	
	public CastleArray(int size)
	{
		Elements = new GameObject[size];
	}
	
	public void SetSize(int size)
	{
		Elements = new GameObject[size];
	}
}


public class CastleCreationScript : CoreBehavior 
{
	public GameObject BrickPrefab;

	public int WallDepth = 3;
	public int WallHeight = 5;
	public int WallLength = 10;
	
	List<List<CastleArray>> castleLevels = new List<List<CastleArray>>();
	
	
	// Use this for initialization
	void Start () 
	{
		//create 3d holder
		for(int j = 0; j < WallHeight; j++)//one for each level
		{
			List<CastleArray> CastleElements = new List<CastleArray>();
			for(int i = 0; i < WallLength; i++)//a square for each level 
			{
				CastleArray CA = new CastleArray(WallLength);
				CastleElements.Add(CA);
			}
			castleLevels.Add(CastleElements);
		}
		
		//spawn bricks at approriate locations and add to holder
		
		for(int i = 0; i < castleLevels.Count; i++)//height
		{
			for(int j = 0; j< castleLevels[i].Count; j++) //length
			{
				for(int k = 0; k < (castleLevels[i])[j].Elements.Length; k++)
				{
					if(k < WallDepth || k >= (WallLength- WallDepth) || j < WallDepth || j >= (WallLength - WallDepth))
					{
						Vector3 pos = new Vector3(j, i, k);
						pos += transform.position;
						GameObject brick = (GameObject)Instantiate(BrickPrefab, pos, BrickPrefab.transform.rotation);
						(castleLevels[i])[j].Elements[k] = brick;
					}
				}
			}
		}
		
	}
}
