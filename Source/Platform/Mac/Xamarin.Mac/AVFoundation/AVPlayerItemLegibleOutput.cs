using System;
using System.ComponentModel;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVPlayerItemLegibleOutput", true)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVPlayerItemLegibleOutput : AVPlayerItemOutput
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAdvanceIntervalForDelegateInvocation = "advanceIntervalForDelegateInvocation";

	private static readonly IntPtr selAdvanceIntervalForDelegateInvocationHandle = Selector.GetHandle("advanceIntervalForDelegateInvocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegateQueue = "delegateQueue";

	private static readonly IntPtr selDelegateQueueHandle = Selector.GetHandle("delegateQueue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMediaSubtypesForNativeRepresentation_ = "initWithMediaSubtypesForNativeRepresentation:";

	private static readonly IntPtr selInitWithMediaSubtypesForNativeRepresentation_Handle = Selector.GetHandle("initWithMediaSubtypesForNativeRepresentation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAdvanceIntervalForDelegateInvocation_ = "setAdvanceIntervalForDelegateInvocation:";

	private static readonly IntPtr selSetAdvanceIntervalForDelegateInvocation_Handle = Selector.GetHandle("setAdvanceIntervalForDelegateInvocation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_Queue_ = "setDelegate:queue:";

	private static readonly IntPtr selSetDelegate_Queue_Handle = Selector.GetHandle("setDelegate:queue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextStylingResolution_ = "setTextStylingResolution:";

	private static readonly IntPtr selSetTextStylingResolution_Handle = Selector.GetHandle("setTextStylingResolution:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextStylingResolution = "textStylingResolution";

	private static readonly IntPtr selTextStylingResolutionHandle = Selector.GetHandle("textStylingResolution");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVPlayerItemLegibleOutput");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextStylingResolutionDefault;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextStylingResolutionSourceAndRulesOnly;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double AdvanceIntervalForDelegateInvocation
	{
		[Export("advanceIntervalForDelegateInvocation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selAdvanceIntervalForDelegateInvocationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selAdvanceIntervalForDelegateInvocationHandle);
		}
		[Export("setAdvanceIntervalForDelegateInvocation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetAdvanceIntervalForDelegateInvocation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetAdvanceIntervalForDelegateInvocation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IAVPlayerItemLegibleOutputPushDelegate? Delegate
	{
		[Export("delegate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IAVPlayerItemLegibleOutputPushDelegate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle), owns: false);
			}
			return Runtime.GetINativeObject<IAVPlayerItemLegibleOutputPushDelegate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DispatchQueue? DelegateQueue
	{
		[Export("delegateQueue", ArgumentSemantic.Copy)]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateQueueHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateQueueHandle));
			return (intPtr == IntPtr.Zero) ? null : new DispatchQueue(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString TextStylingResolution
	{
		[Export("textStylingResolution", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextStylingResolutionHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextStylingResolutionHandle));
		}
		[Export("setTextStylingResolution:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextStylingResolution_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextStylingResolution_Handle, value.Handle);
			}
		}
	}

	[Field("AVPlayerItemLegibleOutputTextStylingResolutionDefault", "AVFoundation")]
	public static NSString TextStylingResolutionDefault
	{
		get
		{
			if (_TextStylingResolutionDefault == null)
			{
				_TextStylingResolutionDefault = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVPlayerItemLegibleOutputTextStylingResolutionDefault");
			}
			return _TextStylingResolutionDefault;
		}
	}

	[Field("AVPlayerItemLegibleOutputTextStylingResolutionSourceAndRulesOnly", "AVFoundation")]
	public static NSString TextStylingResolutionSourceAndRulesOnly
	{
		get
		{
			if (_TextStylingResolutionSourceAndRulesOnly == null)
			{
				_TextStylingResolutionSourceAndRulesOnly = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVPlayerItemLegibleOutputTextStylingResolutionSourceAndRulesOnly");
			}
			return _TextStylingResolutionSourceAndRulesOnly;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVPlayerItemLegibleOutput()
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
	protected AVPlayerItemLegibleOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVPlayerItemLegibleOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMediaSubtypesForNativeRepresentation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVPlayerItemLegibleOutput(NSNumber[] subtypesFourCCcodes)
		: base(NSObjectFlag.Empty)
	{
		if (subtypesFourCCcodes == null)
		{
			throw new ArgumentNullException("subtypesFourCCcodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(subtypesFourCCcodes);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithMediaSubtypesForNativeRepresentation_Handle, nSArray.Handle), "initWithMediaSubtypesForNativeRepresentation:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithMediaSubtypesForNativeRepresentation_Handle, nSArray.Handle), "initWithMediaSubtypesForNativeRepresentation:");
		}
		nSArray.Dispose();
	}

	[Export("setDelegate:queue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDelegate(IAVPlayerItemLegibleOutputPushDelegate? delegateObject, DispatchQueue? delegateQueue)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetDelegate_Queue_Handle, delegateObject?.Handle ?? IntPtr.Zero, (delegateQueue == null) ? IntPtr.Zero : delegateQueue.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetDelegate_Queue_Handle, delegateObject?.Handle ?? IntPtr.Zero, (delegateQueue == null) ? IntPtr.Zero : delegateQueue.Handle);
		}
	}
}
