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
	#endregion
}
