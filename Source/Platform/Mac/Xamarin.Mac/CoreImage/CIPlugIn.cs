using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIPlugIn", true)]
public class CIPlugIn : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadAllPlugIns = "loadAllPlugIns";

	private static readonly IntPtr selLoadAllPlugInsHandle = Selector.GetHandle("loadAllPlugIns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadNonExecutablePlugIn_ = "loadNonExecutablePlugIn:";

	private static readonly IntPtr selLoadNonExecutablePlugIn_Handle = Selector.GetHandle("loadNonExecutablePlugIn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadNonExecutablePlugIns = "loadNonExecutablePlugIns";

	private static readonly IntPtr selLoadNonExecutablePlugInsHandle = Selector.GetHandle("loadNonExecutablePlugIns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadPlugIn_AllowNonExecutable_ = "loadPlugIn:allowNonExecutable:";

	private static readonly IntPtr selLoadPlugIn_AllowNonExecutable_Handle = Selector.GetHandle("loadPlugIn:allowNonExecutable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIPlugIn");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CIPlugIn()
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
	protected CIPlugIn(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIPlugIn(IntPtr handle)
		: base(handle)
	{
	}

	[Export("loadAllPlugIns")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'LoadNonExecutablePlugIns' for non-executable plugins instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void LoadAllPlugIns()
	{
		Messaging.void_objc_msgSend(class_ptr, selLoadAllPlugInsHandle);
	}

	[Export("loadNonExecutablePlugIn:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void LoadNonExecutablePlugIn(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selLoadNonExecutablePlugIn_Handle, url.Handle);
	}

	[Export("loadNonExecutablePlugIns")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void LoadNonExecutablePlugIns()
	{
		Messaging.void_objc_msgSend(class_ptr, selLoadNonExecutablePlugInsHandle);
	}

	[Export("loadPlugIn:allowNonExecutable:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void LoadPlugIn(NSUrl pluginUrl, bool allowNonExecutable)
	{
		if (pluginUrl == null)
		{
			throw new ArgumentNullException("pluginUrl");
		}
		Messaging.void_objc_msgSend_IntPtr_bool(class_ptr, selLoadPlugIn_AllowNonExecutable_Handle, pluginUrl.Handle, allowNonExecutable);
	}
}
