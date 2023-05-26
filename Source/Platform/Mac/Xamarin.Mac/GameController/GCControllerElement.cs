using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameController;

[Register("GCControllerElement", true)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class GCControllerElement : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollection = "collection";

	private static readonly IntPtr selCollectionHandle = Selector.GetHandle("collection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAnalog = "isAnalog";

	private static readonly IntPtr selIsAnalogHandle = Selector.GetHandle("isAnalog");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GCControllerElement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Collection_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCControllerElement? Collection
	{
		[Export("collection", ArgumentSemantic.Assign)]
		get
		{
			GCControllerElement gCControllerElement = ((!base.IsDirectBinding) ? Runtime.GetNSObject<GCControllerElement>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCollectionHandle)) : Runtime.GetNSObject<GCControllerElement>(Messaging.IntPtr_objc_msgSend(base.Handle, selCollectionHandle)));
			MarkDirty();
			__mt_Collection_var = gCControllerElement;
			return gCControllerElement;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsAnalog
	{
		[Export("isAnalog")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAnalogHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAnalogHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GCControllerElement(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GCControllerElement(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Collection_var = null;
		}
	}
}
