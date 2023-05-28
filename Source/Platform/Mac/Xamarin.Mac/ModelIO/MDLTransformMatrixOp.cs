using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace ModelIO;

[Register("MDLTransformMatrixOp", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class MDLTransformMatrixOp : NSObject, IMDLTransformOp, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsInverseOp = "IsInverseOp";

	private static readonly IntPtr selIsInverseOpHandle = Selector.GetHandle("IsInverseOp");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimatedValue = "animatedValue";

	private static readonly IntPtr selAnimatedValueHandle = Selector.GetHandle("animatedValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDouble4x4AtTime_ = "double4x4AtTime:";

	private static readonly IntPtr selDouble4x4AtTime_Handle = Selector.GetHandle("double4x4AtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloat4x4AtTime_ = "float4x4AtTime:";

	private static readonly IntPtr selFloat4x4AtTime_Handle = Selector.GetHandle("float4x4AtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLTransformMatrixOp");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLAnimatedMatrix4x4 AnimatedValue
	{
		[Export("animatedValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLAnimatedMatrix4x4>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimatedValueHandle));
			}
			return Runtime.GetNSObject<MDLAnimatedMatrix4x4>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimatedValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual bool IsInverseOp
	{
		[Export("IsInverseOp")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsInverseOpHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsInverseOpHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLTransformMatrixOp()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLTransformMatrixOp(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLTransformMatrixOp(IntPtr handle)
		: base(handle)
	{
	}

	[Export("float4x4AtTime:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NMatrix4 GetNMatrix4(double atTime)
	{
		NMatrix4 retval;
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret_Double(out retval, base.Handle, selFloat4x4AtTime_Handle, atTime);
		}
		else
		{
			Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper_stret_Double(out retval, base.SuperHandle, selFloat4x4AtTime_Handle, atTime);
		}
		return retval;
	}

	[Export("double4x4AtTime:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NMatrix4d GetNMatrix4d(double atTime)
	{
		NMatrix4d retval;
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__NMatrix4d_objc_msgSend_stret_Double(out retval, base.Handle, selDouble4x4AtTime_Handle, atTime);
		}
		else
		{
			Messaging.xamarin_simd__NMatrix4d_objc_msgSendSuper_stret_Double(out retval, base.SuperHandle, selDouble4x4AtTime_Handle, atTime);
		}
		return retval;
	}
}
