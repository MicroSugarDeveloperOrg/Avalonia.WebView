using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[iOS(10, 0)]
[Mac(10, 12, 0, PlatformArchitecture.Arch64)]
[Watch(3, 2)]
[Register("INIntentResolutionResult", SkipRegistration = true)]
public sealed class INIntentResolutionResult<ObjectType> : INIntentResolutionResult where ObjectType : class, INativeObject
{
	internal INIntentResolutionResult(IntPtr handle)
		: base(handle)
	{
	}
}
[Register("INIntentResolutionResult", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public abstract class INIntentResolutionResult : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INIntentResolutionResult");

	public static INIntentResolutionResult NeedsValue
	{
		get
		{
			throw new NotImplementedException("All subclasses of INIntentResolutionResult must re-implement this property");
		}
	}

	public static INIntentResolutionResult NotRequired
	{
		get
		{
			throw new NotImplementedException("All subclasses of INIntentResolutionResult must re-implement this property");
		}
	}

	public static INIntentResolutionResult Unsupported
	{
		get
		{
			throw new NotImplementedException("All subclasses of INIntentResolutionResult must re-implement this property");
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected INIntentResolutionResult(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INIntentResolutionResult(IntPtr handle)
		: base(handle)
	{
	}
}
