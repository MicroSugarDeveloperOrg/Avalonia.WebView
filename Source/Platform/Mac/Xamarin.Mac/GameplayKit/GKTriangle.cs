using System;
using System.Runtime.InteropServices;
using ObjCRuntime;
using OpenTK;

namespace GameplayKit;

[iOS(10, 0)]
[TV(10, 0)]
[Mac(10, 12)]
public struct GKTriangle
{
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
	private Vector3[] points;

	public Vector3[] Points
	{
		get
		{
			return points ?? (points = new Vector3[3]);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.Length != 3)
			{
				throw new ArgumentOutOfRangeException("value", "The length of the Value array must be 3");
			}
			points = value;
		}
	}
}
