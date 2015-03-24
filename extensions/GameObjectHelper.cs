using UnityEngine;
using System.Collections;

public static class GameObjectHelper
{
	#region Setters
	public static void SetX(this GameObject gameObject, float x)
	{
		gameObject.transform.position = new Vector3(x, gameObject.transform.position.y, gameObject.transform.position.z);
	}
	
	public static void SetY(this GameObject gameObject, float y)
	{
		gameObject.transform.position = new Vector3(gameObject.transform.position.x, y, gameObject.transform.position.z);
	}
	
	public static void SetZ(this GameObject gameObject, float z)
	{
		gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, z);
	}
	
	public static void SetPosition(this GameObject gameObject, float x, float y, float z)
	{
		gameObject.transform.position = new Vector3(x, y, z);	
	}
	#endregion
	
	#region Getters
	public static Vector3 Position(this GameObject gameObject)
	{
		return gameObject.transform.position;
	}
	
	public static float XPos(this GameObject gameObject)
	{
		return gameObject.transform.position.x;
	}
	
	public static float YPos(this GameObject gameObject)
	{
		return gameObject.transform.position.y;
	}
	
	public static float ZPos(this GameObject gameObject)
	{
		return gameObject.transform.position.z;
	}
	#endregion
	
	#region Helpers
	public static Vector3 PositionWithOverrideX(this GameObject gameObject, float xOverride)
	{
		return new Vector3(xOverride, gameObject.transform.position.y, gameObject.transform.position.z);
	}
	
	public static Vector3 PositionWithOverrideY(this GameObject gameObject, float yOverride)
	{
		return new Vector3(gameObject.transform.position.x, yOverride, gameObject.transform.position.z);
	}
	
	public static Vector3 PositionWithOverrideZ(this GameObject gameObject, float zOverride)
	{
		return new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, zOverride);
	}
	#endregion
}

