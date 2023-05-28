using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
public class SCNPhysicsTest : DictionaryContainer
{
	public SCNPhysicsSearchMode SearchMode
	{
		get
		{
			NSString searchMode = _SearchMode;
			if (searchMode == SCNPhysicsTestSearchModeKeys.Any)
			{
				return SCNPhysicsSearchMode.Any;
			}
			if (searchMode == SCNPhysicsTestSearchModeKeys.Closest)
			{
				return SCNPhysicsSearchMode.Closest;
			}
			if (searchMode == SCNPhysicsTestSearchModeKeys.All)
			{
				return SCNPhysicsSearchMode.All;
			}
			return SCNPhysicsSearchMode.Unknown;
		}
		set
		{
			switch (value)
			{
			case SCNPhysicsSearchMode.All:
				_SearchMode = SCNPhysicsTestSearchModeKeys.All;
				break;
			case SCNPhysicsSearchMode.Closest:
				_SearchMode = SCNPhysicsTestSearchModeKeys.Closest;
				break;
			case SCNPhysicsSearchMode.Any:
				_SearchMode = SCNPhysicsTestSearchModeKeys.Any;
				break;
			default:
				throw new ArgumentException("Invalid value passed to SearchMode property");
			}
		}
	}

	public nuint? CollisionBitMask
	{
		get
		{
			return GetNUIntValue(SCNPhysicsTestKeys.CollisionBitMaskKey);
		}
		set
		{
			SetNumberValue(SCNPhysicsTestKeys.CollisionBitMaskKey, value);
		}
	}

	public bool? BackfaceCulling
	{
		get
		{
			return GetBoolValue(SCNPhysicsTestKeys.BackfaceCullingKey);
		}
		set
		{
			SetBooleanValue(SCNPhysicsTestKeys.BackfaceCullingKey, value);
		}
	}

	internal NSString? _SearchMode
	{
		get
		{
			return GetNSStringValue(SCNPhysicsTestKeys.SearchModeKey);
		}
		set
		{
			SetStringValue(SCNPhysicsTestKeys.SearchModeKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public SCNPhysicsTest()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public SCNPhysicsTest(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
