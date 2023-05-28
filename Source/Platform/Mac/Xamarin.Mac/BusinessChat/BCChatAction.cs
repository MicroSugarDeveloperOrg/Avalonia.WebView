using System;
using System.Collections.Generic;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace BusinessChat;

[Register("BCChatAction", true)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class BCChatAction : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenTranscript_IntentParameters_ = "openTranscript:intentParameters:";

	private static readonly IntPtr selOpenTranscript_IntentParameters_Handle = Selector.GetHandle("openTranscript:intentParameters:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("BCChatAction");

	public override IntPtr ClassHandle => class_ptr;

	public static void OpenTranscript(string businessIdentifier, Dictionary<BCParameterName, string> intentParameters)
	{
		NSString[] array = new NSString[intentParameters.Keys.Count];
		NSString[] array2 = new NSString[intentParameters.Keys.Count];
		int num = 0;
		foreach (BCParameterName key in intentParameters.Keys)
		{
			array[num] = key.GetConstant();
			array2[num] = new NSString(intentParameters[key]);
			num++;
		}
		using NSDictionary<NSString, NSString> intentParameters2 = NSDictionary<NSString, NSString>.FromObjectsAndKeys(array2, array, array.Length);
		OpenTranscript(businessIdentifier, intentParameters2);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected BCChatAction(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal BCChatAction(IntPtr handle)
		: base(handle)
	{
	}

	[Export("openTranscript:intentParameters:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OpenTranscript(string businessIdentifier, NSDictionary<NSString, NSString> intentParameters)
	{
		if (businessIdentifier == null)
		{
			throw new ArgumentNullException("businessIdentifier");
		}
		if (intentParameters == null)
		{
			throw new ArgumentNullException("intentParameters");
		}
		IntPtr arg = NSString.CreateNative(businessIdentifier);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selOpenTranscript_IntentParameters_Handle, arg, intentParameters.Handle);
		NSString.ReleaseNative(arg);
	}
}
