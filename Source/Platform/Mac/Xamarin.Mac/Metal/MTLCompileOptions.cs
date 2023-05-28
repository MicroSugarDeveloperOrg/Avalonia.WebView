using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Register("MTLCompileOptions", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MTLCompileOptions : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFastMathEnabled = "fastMathEnabled";

	private static readonly IntPtr selFastMathEnabledHandle = Selector.GetHandle("fastMathEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLanguageVersion = "languageVersion";

	private static readonly IntPtr selLanguageVersionHandle = Selector.GetHandle("languageVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreprocessorMacros = "preprocessorMacros";

	private static readonly IntPtr selPreprocessorMacrosHandle = Selector.GetHandle("preprocessorMacros");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFastMathEnabled_ = "setFastMathEnabled:";

	private static readonly IntPtr selSetFastMathEnabled_Handle = Selector.GetHandle("setFastMathEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLanguageVersion_ = "setLanguageVersion:";

	private static readonly IntPtr selSetLanguageVersion_Handle = Selector.GetHandle("setLanguageVersion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreprocessorMacros_ = "setPreprocessorMacros:";

	private static readonly IntPtr selSetPreprocessorMacros_Handle = Selector.GetHandle("setPreprocessorMacros:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLCompileOptions");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FastMathEnabled
	{
		[Export("fastMathEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selFastMathEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFastMathEnabledHandle);
		}
		[Export("setFastMathEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFastMathEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFastMathEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual MTLLanguageVersion LanguageVersion
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("languageVersion", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLLanguageVersion)Messaging.UInt64_objc_msgSend(base.Handle, selLanguageVersionHandle);
			}
			return (MTLLanguageVersion)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLanguageVersionHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setLanguageVersion:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetLanguageVersion_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetLanguageVersion_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? PreprocessorMacros
	{
		[Export("preprocessorMacros", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreprocessorMacrosHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreprocessorMacrosHandle));
		}
		[Export("setPreprocessorMacros:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPreprocessorMacros_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPreprocessorMacros_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLCompileOptions()
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
	protected MTLCompileOptions(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLCompileOptions(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}
}
