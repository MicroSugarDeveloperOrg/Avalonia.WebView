using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFActionGoTo", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class PdfActionGoTo : PdfAction
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestination = "destination";

	private static readonly IntPtr selDestinationHandle = Selector.GetHandle("destination");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDestination_ = "initWithDestination:";

	private static readonly IntPtr selInitWithDestination_Handle = Selector.GetHandle("initWithDestination:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDestination_ = "setDestination:";

	private static readonly IntPtr selSetDestination_Handle = Selector.GetHandle("setDestination:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PDFActionGoTo");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfDestination Destination
	{
		[Export("destination")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<PdfDestination>(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationHandle));
			}
			return Runtime.GetNSObject<PdfDestination>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationHandle));
		}
		[Export("setDestination:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDestination_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDestination_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfActionGoTo()
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
	protected PdfActionGoTo(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PdfActionGoTo(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDestination:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PdfActionGoTo(PdfDestination destination)
		: base(NSObjectFlag.Empty)
	{
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithDestination_Handle, destination.Handle), "initWithDestination:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithDestination_Handle, destination.Handle), "initWithDestination:");
		}
	}
}
