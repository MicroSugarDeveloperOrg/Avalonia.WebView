using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Watch(3, 0)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
public class SCNHitTestOptions : DictionaryContainer
{
	[Obsolete("Use 'SearchMode' instead.")]
	public SCNHitTestSearchMode? OptionSearchMode => SearchMode;

	public bool? FirstFoundOnly
	{
		get
		{
			return GetBoolValue(SCNHitTest.FirstFoundOnlyKey);
		}
		set
		{
			SetBooleanValue(SCNHitTest.FirstFoundOnlyKey, value);
		}
	}

	public bool? SortResults
	{
		get
		{
			return GetBoolValue(SCNHitTest.SortResultsKey);
		}
		set
		{
			SetBooleanValue(SCNHitTest.SortResultsKey, value);
		}
	}

	public bool? BackFaceCulling
	{
		get
		{
			return GetBoolValue(SCNHitTest.BackFaceCullingKey);
		}
		set
		{
			SetBooleanValue(SCNHitTest.BackFaceCullingKey, value);
		}
	}

	public bool? BoundingBoxOnly
	{
		get
		{
			return GetBoolValue(SCNHitTest.BoundingBoxOnlyKey);
		}
		set
		{
			SetBooleanValue(SCNHitTest.BoundingBoxOnlyKey, value);
		}
	}

	public bool? IgnoreChildNodes
	{
		get
		{
			return GetBoolValue(SCNHitTest.IgnoreChildNodesKey);
		}
		set
		{
			SetBooleanValue(SCNHitTest.IgnoreChildNodesKey, value);
		}
	}

	public bool? IgnoreHiddenNodes
	{
		get
		{
			return GetBoolValue(SCNHitTest.IgnoreHiddenNodesKey);
		}
		set
		{
			SetBooleanValue(SCNHitTest.IgnoreHiddenNodesKey, value);
		}
	}

	public SCNNode? RootNode
	{
		get
		{
			return base.Dictionary[SCNHitTest.RootNodeKey] as SCNNode;
		}
		set
		{
			SetNativeValue(SCNHitTest.RootNodeKey, value);
		}
	}

	public SCNHitTestSearchMode? SearchMode
	{
		get
		{
			return (SCNHitTestSearchMode?)GetLongValue(SCNHitTest.SearchModeKey);
		}
		set
		{
			SetNumberValue(SCNHitTest.SearchModeKey, (long?)value);
		}
	}

	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public bool? IgnoreLightArea
	{
		get
		{
			return GetBoolValue(SCNHitTest.IgnoreLightAreaKey);
		}
		set
		{
			SetBooleanValue(SCNHitTest.IgnoreLightAreaKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public SCNHitTestOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public SCNHitTestOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
