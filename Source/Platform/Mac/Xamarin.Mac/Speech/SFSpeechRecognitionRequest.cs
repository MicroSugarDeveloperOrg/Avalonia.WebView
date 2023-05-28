using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Speech;

[Register("SFSpeechRecognitionRequest", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public abstract class SFSpeechRecognitionRequest : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContextualStrings = "contextualStrings";

	private static readonly IntPtr selContextualStringsHandle = Selector.GetHandle("contextualStrings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInteractionIdentifier = "interactionIdentifier";

	private static readonly IntPtr selInteractionIdentifierHandle = Selector.GetHandle("interactionIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequiresOnDeviceRecognition = "requiresOnDeviceRecognition";

	private static readonly IntPtr selRequiresOnDeviceRecognitionHandle = Selector.GetHandle("requiresOnDeviceRecognition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContextualStrings_ = "setContextualStrings:";

	private static readonly IntPtr selSetContextualStrings_Handle = Selector.GetHandle("setContextualStrings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInteractionIdentifier_ = "setInteractionIdentifier:";

	private static readonly IntPtr selSetInteractionIdentifier_Handle = Selector.GetHandle("setInteractionIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRequiresOnDeviceRecognition_ = "setRequiresOnDeviceRecognition:";

	private static readonly IntPtr selSetRequiresOnDeviceRecognition_Handle = Selector.GetHandle("setRequiresOnDeviceRecognition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldReportPartialResults_ = "setShouldReportPartialResults:";

	private static readonly IntPtr selSetShouldReportPartialResults_Handle = Selector.GetHandle("setShouldReportPartialResults:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTaskHint_ = "setTaskHint:";

	private static readonly IntPtr selSetTaskHint_Handle = Selector.GetHandle("setTaskHint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldReportPartialResults = "shouldReportPartialResults";

	private static readonly IntPtr selShouldReportPartialResultsHandle = Selector.GetHandle("shouldReportPartialResults");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTaskHint = "taskHint";

	private static readonly IntPtr selTaskHintHandle = Selector.GetHandle("taskHint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SFSpeechRecognitionRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] ContextualStrings
	{
		[Export("contextualStrings", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selContextualStringsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContextualStringsHandle));
		}
		[Export("setContextualStrings:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContextualStrings_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContextualStrings_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? InteractionIdentifier
	{
		[Export("interactionIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInteractionIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInteractionIdentifierHandle));
		}
		[Export("setInteractionIdentifier:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInteractionIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInteractionIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool RequiresOnDeviceRecognition
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("requiresOnDeviceRecognition")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRequiresOnDeviceRecognitionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRequiresOnDeviceRecognitionHandle);
		}
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setRequiresOnDeviceRecognition:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRequiresOnDeviceRecognition_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRequiresOnDeviceRecognition_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldReportPartialResults
	{
		[Export("shouldReportPartialResults")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldReportPartialResultsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldReportPartialResultsHandle);
		}
		[Export("setShouldReportPartialResults:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldReportPartialResults_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldReportPartialResults_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SFSpeechRecognitionTaskHint TaskHint
	{
		[Export("taskHint", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SFSpeechRecognitionTaskHint)Messaging.Int64_objc_msgSend(base.Handle, selTaskHintHandle);
			}
			return (SFSpeechRecognitionTaskHint)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTaskHintHandle);
		}
		[Export("setTaskHint:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetTaskHint_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetTaskHint_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SFSpeechRecognitionRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SFSpeechRecognitionRequest(IntPtr handle)
		: base(handle)
	{
	}
}
