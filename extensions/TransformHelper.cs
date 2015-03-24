using UnityEngine;
using System.Collections;

public static class TransformHelper 
{
	#region Setters
	public static void SetX(this Transform transform, float x)
	{
		transform.position = new Vector3(x, transform.position.y, transform.position.z);
	}
	
	public static void SetY(this Transform transform, float y)
	{
		transform.position = new Vector3(transform.position.x, y, transform.position.z);
	}
	
	public static void SetZ(this Transform transform, float z)
	{
		transform.position = new Vector3(transform.position.x, transform.position.y, z);
	}
	
	public static void SetPosition(this Transform transform, float x, float y, float z)
	{
		transform.position = new Vector3(x, y, z);	
	}
	
	public static void ScaleX(this Transform transform, float x)
	{
		transform.localScale = new Vector3(x, transform.localScale.y, transform.localScale.z);
	}
	
	public static void ScaleY(this Transform transform, float y)
	{
		transform.localScale = new Vector3(transform.localScale.x, y, transform.localScale.z);
	}
	
	public static void ScaleZ(this Transform transform, float z)
	{
		transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, z);
	}
	#endregion
	
	#region Getters
	public static float XPos(this Transform transform)
	{
		return transform.position.x;
	}
	
	public static float YPos(this Transform transform)
	{
		return transform.position.y;
	}
	
	public static float ZPos(this Transform transform)
	{
		return transform.position.z;
	}
	#endregion
}
