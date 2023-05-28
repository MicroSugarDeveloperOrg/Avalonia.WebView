using System;
using System.ComponentModel;
using CoreML;
using Foundation;
using ObjCRuntime;

namespace SoundAnalysis;

[Register("SNClassifySoundRequest", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class SNClassifySoundRequest : NSObject, ISNRequest, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMLModel_Error_ = "initWithMLModel:error:";

	private static readonly IntPtr selInitWithMLModel_Error_Handle = Selector.GetHandle("initWithMLModel:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOverlapFactor = "overlapFactor";

	private static readonly IntPtr selOverlapFactorHandle = Selector.GetHandle("overlapFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOverlapFactor_ = "setOverlapFactor:";

	private static readonly IntPtr selSetOverlapFactor_Handle = Selector.GetHandle("setOverlapFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SNClassifySoundRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double OverlapFactor
	{
		[Export("overlapFactor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selOverlapFactorHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selOverlapFactorHandle);
		}
		[Export("setOverlapFactor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetOverlapFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetOverlapFactor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SNClassifySoundRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SNClassifySoundRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMLModel:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SNClassifySoundRequest(MLModel mlModel, out NSError? error)
		: base(NSObjectFlag.Empty)
	{
		if (mlModel == null)
		{
			throw new ArgumentNullException("mlModel");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithMLModel_Error_Handle, mlModel.Handle, ref arg), "initWithMLModel:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithMLModel_Error_Handle, mlModel.Handle, ref arg), "initWithMLModel:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}
}
