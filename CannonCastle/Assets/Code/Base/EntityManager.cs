using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EntityManager : CoreBehavior
{
	Dictionary<string, Entity> Entities = new Dictionary<string, Entity>();
	

	public void Add(Entity entity)
	{
		Entities.Add(entity.EntityID,entity);
	}
	
	public bool Contains(Entity entity)
	{
		return Contains(entity.EntityID);
	}
	
	public bool Contains(string entityID)
	{
		return Entities.ContainsKey(entityID);
	}
	
	public Entity GetEntity(string entityID)
	{
		Entity value;
		Entities.TryGetValue(entityID, out value);
		return value;
	}
	
	public void Remove(Entity entity)
	{
		Remove(entity.EntityID);
	}
	
	public void Remove(string entityID)
	{
		Entities.Remove(entityID);
	}
	
}
