using UnityEngine;
using System.Collections;

public static class Vector3Helper 
{	
	#region Getters
	public static Vector2 XY(this Vector3 vector)
	{
		return new Vector2(vector.x, vector.y);
	}
	
	public static Vector2 YZ(this Vector3 vector)
	{
		return new Vector2(vector.y, vector.z);
	}
	
	public static Vector3 PlusX(this Vector3 vector, float x)
	{
		Vector3 vec = new Vector3() + vector;
		vec.x += x;
		return vec;
	}
	
	public static Vector3 PlusY(this Vector3 vector, float y)
	{
		Vector3 vec = new Vector3() + vector;
		vec.y += y;
		return vec;
	}
	
	public static Vector3 PlusZ(this Vector3 vector, float z)
	{
		Vector3 vec = new Vector3() + vector;
		vec.z += z;
		return vec;
	}
	
	public static Vector3 MinusX(this Vector3 vector, float x)
	{
		Vector3 vec = new Vector3() + vector;
		vec.x -= x;
		return vec;
	}
	
	public static Vector3 MinusY(this Vector3 vector, float y)
	{
		Vector3 vec = new Vector3() + vector;
		vec.y -= y;
		return vec;
	}
	
	public static Vector3 MinusZ(this Vector3 vector, float z)
	{
		Vector3 vec = new Vector3() + vector;
		vec.z -= z;
		return vec;
	}
	
	public static Vector3 ScaleX(this Vector3 vector, float x)
	{
		Vector3 vec = new Vector3() + vector;
		vec.x *= x;
		return vec;
	}
	
	public static Vector3 ScaleY(this Vector3 vector, float y)
	{
		Vector3 vec = new Vector3() + vector;
		vec.y *= y;
		return vec;
	}
	
	public static Vector3 ScaleZ(this Vector3 vector, float z)
	{
		Vector3 vec = new Vector3() + vector;
		vec.z *= z;
		return vec;
	}
	#endregion
}
