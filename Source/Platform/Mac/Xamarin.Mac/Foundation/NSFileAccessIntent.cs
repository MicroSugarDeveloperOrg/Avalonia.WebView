using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSFileAccessIntent", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSFileAccessIntent : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURL = "URL";

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadingIntentWithURL_Options_ = "readingIntentWithURL:options:";

	private static readonly IntPtr selReadingIntentWithURL_Options_Handle = Selector.GetHandle("readingIntentWithURL:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWritingIntentWithURL_Options_ = "writingIntentWithURL:options:";

	private static readonly IntPtr selWritingIntentWithURL_Options_Handle = Selector.GetHandle("writingIntentWithURL:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSFileAccessIntent");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl Url
	{
		[Export("URL", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSFileAccessIntent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSFileAccessIntent(IntPtr handle)
		: base(handle)
	{
	}

	[Export("readingIntentWithURL:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFileAccessIntent CreateReadingIntent(NSUrl url, NSFileCoordinatorReadingOptions options)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<NSFileAccessIntent>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(class_ptr, selReadingIntentWithURL_Options_Handle, url.Handle, (ulong)options));
	}

	[Export("writingIntentWithURL:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFileAccessIntent CreateWritingIntent(NSUrl url, NSFileCoordinatorWritingOptions options)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<NSFileAccessIntent>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(class_ptr, selWritingIntentWithURL_Options_Handle, url.Handle, (ulong)options));
	}
}
