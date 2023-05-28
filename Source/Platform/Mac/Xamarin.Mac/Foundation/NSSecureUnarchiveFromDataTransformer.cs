using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSSecureUnarchiveFromDataTransformer", true)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class NSSecureUnarchiveFromDataTransformer : NSValueTransformer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowedTopLevelClasses = "allowedTopLevelClasses";

	private static readonly IntPtr selAllowedTopLevelClassesHandle = Selector.GetHandle("allowedTopLevelClasses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSSecureUnarchiveFromDataTransformer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Class[] AllowedTopLevelClasses
	{
		[Export("allowedTopLevelClasses", ArgumentSemantic.Copy)]
		get
		{
			return NSArray.ArrayFromHandle<Class>(Messaging.IntPtr_objc_msgSend(class_ptr, selAllowedTopLevelClassesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Type[] AllowedTopLevelTypes => Array.ConvertAll(AllowedTopLevelClasses, (Class c) => ObjCRuntime.Class.Lookup(c));

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSecureUnarchiveFromDataTransformer()
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
	protected NSSecureUnarchiveFromDataTransformer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSecureUnarchiveFromDataTransformer(IntPtr handle)
		: base(handle)
	{
	}
}
