using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Register("MDLMaterialPropertyConnection", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
public class MDLMaterialPropertyConnection : NSObject, IMDLNamed, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithOutput_Input_ = "initWithOutput:input:";

	private static readonly IntPtr selInitWithOutput_Input_Handle = Selector.GetHandle("initWithOutput:input:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInput = "input";

	private static readonly IntPtr selInputHandle = Selector.GetHandle("input");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutput = "output";

	private static readonly IntPtr selOutputHandle = Selector.GetHandle("output");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLMaterialPropertyConnection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Input_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Output_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty? Input
	{
		[Export("input", ArgumentSemantic.Weak)]
		get
		{
			MDLMaterialProperty mDLMaterialProperty = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputHandle)) : Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputHandle)));
			MarkDirty();
			__mt_Input_var = mDLMaterialProperty;
			return mDLMaterialProperty;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
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
		[Export("setName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty? Output
	{
		[Export("output", ArgumentSemantic.Weak)]
		get
		{
			MDLMaterialProperty mDLMaterialProperty = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputHandle)) : Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputHandle)));
			MarkDirty();
			__mt_Output_var = mDLMaterialProperty;
			return mDLMaterialProperty;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLMaterialPropertyConnection(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLMaterialPropertyConnection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithOutput:input:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLMaterialPropertyConnection(MDLMaterialProperty output, MDLMaterialProperty input)
		: base(NSObjectFlag.Empty)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithOutput_Input_Handle, output.Handle, input.Handle), "initWithOutput:input:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithOutput_Input_Handle, output.Handle, input.Handle), "initWithOutput:input:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Input_var = null;
			__mt_Output_var = null;
		}
	}
}
