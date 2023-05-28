using Foundation;

namespace SceneKit;

[Mac(10, 10)]
[iOS(8, 0)]
public class SCNPhysicsShapeOptions
{
	public SCNPhysicsShapeType? ShapeType { get; set; }

	public bool? KeepAsCompound { get; set; }

	public SCNVector3? Scale { get; set; }

	public SCNPhysicsShapeOptions()
	{
	}

	internal SCNPhysicsShapeOptions(NSDictionary source)
	{
		NSString nSString = source[SCNPhysicsShapeOptionsKeys.Type] as NSString;
		if (nSString != null)
		{
			if (nSString == SCNPhysicsShapeOptionsTypes.BoundingBox)
			{
				ShapeType = SCNPhysicsShapeType.BoundingBox;
			}
			else if (nSString == SCNPhysicsShapeOptionsTypes.ConcavePolyhedron)
			{
				ShapeType = SCNPhysicsShapeType.ConcavePolyhedron;
			}
			else if (nSString == SCNPhysicsShapeOptionsTypes.ConvexHull)
			{
				ShapeType = SCNPhysicsShapeType.ConvexHull;
			}
		}
		if (source[SCNPhysicsShapeOptionsKeys.KeepAsCompound] is NSNumber nSNumber)
		{
			KeepAsCompound = nSNumber.Int32Value != 0;
		}
		if (source[SCNPhysicsShapeOptionsKeys.Scale] is NSValue nSValue)
		{
			Scale = nSValue.Vector3Value;
		}
	}

	public NSDictionary ToDictionary()
	{
		int num = 0;
		if (ShapeType.HasValue)
		{
			num++;
		}
		if (KeepAsCompound.HasValue)
		{
			num++;
		}
		if (Scale.HasValue)
		{
			num++;
		}
		if (num == 0)
		{
			return null;
		}
		int num2 = 0;
		NSString[] array = new NSString[num];
		NSObject[] array2 = new NSObject[num];
		if (ShapeType.HasValue)
		{
			array[num2] = SCNPhysicsShapeOptionsKeys.Type;
			switch (ShapeType.Value)
			{
			case SCNPhysicsShapeType.BoundingBox:
				array2[num2] = SCNPhysicsShapeOptionsTypes.BoundingBox;
				break;
			case SCNPhysicsShapeType.ConcavePolyhedron:
				array2[num2] = SCNPhysicsShapeOptionsTypes.ConcavePolyhedron;
				break;
			default:
				array2[num2] = SCNPhysicsShapeOptionsTypes.ConvexHull;
				break;
			}
		}
		if (KeepAsCompound.HasValue)
		{
			array[num2] = SCNPhysicsShapeOptionsKeys.KeepAsCompound;
			array2[num2] = new NSNumber(KeepAsCompound.Value);
		}
		if (Scale.HasValue)
		{
			array[num2] = SCNPhysicsShapeOptionsKeys.Scale;
			array2[num2] = NSValue.FromVector(Scale.Value);
		}
		NSObject[] keys = array;
		return NSDictionary.FromObjectsAndKeys(array2, keys);
	}
}
