using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace SpriteKit;

internal sealed class SKWarpableWrapper : BaseWrapper, ISKWarpable, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKWarpGeometry? WarpGeometry
	{
		[Export("warpGeometry", ArgumentSemantic.Assign)]
		get
		{
			return Runtime.GetNSObject<SKWarpGeometry>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("warpGeometry")));
		}
		[Export("setWarpGeometry:", ArgumentSemantic.Assign)]
		set
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setWarpGeometry:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nint SubdivisionLevels
	{
		[Export("subdivisionLevels")]
		get
		{
			return Messaging.nint_objc_msgSend(base.Handle, Selector.GetHandle("subdivisionLevels"));
		}
		[Export("setSubdivisionLevels:")]
		set
		{
			Messaging.void_objc_msgSend_nint(base.Handle, Selector.GetHandle("setSubdivisionLevels:"), value);
		}
	}

	[Preserve(Conditional = true)]
	public SKWarpableWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
