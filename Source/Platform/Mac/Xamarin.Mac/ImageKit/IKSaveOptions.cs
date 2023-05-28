using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKSaveOptions", true)]
public class IKSaveOptions : NSObject
{
	[Register]
	internal class _IKSaveOptionsDelegate : NSObject, IIKSaveOptionsDelegate, INativeObject, IDisposable
	{
		internal SaveOptionsShouldShowUTType? shouldShowType;

		public _IKSaveOptionsDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("saveOptions:shouldShowUTType:")]
		public bool ShouldShowType(IKSaveOptions saveOptions, string imageUTType)
		{
			return shouldShowType?.Invoke(saveOptions, imageUTType) ?? false;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddSaveOptionsAccessoryViewToSavePanel_ = "addSaveOptionsAccessoryViewToSavePanel:";

	private static readonly IntPtr selAddSaveOptionsAccessoryViewToSavePanel_Handle = Selector.GetHandle("addSaveOptionsAccessoryViewToSavePanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddSaveOptionsToView_ = "addSaveOptionsToView:";

	private static readonly IntPtr selAddSaveOptionsToView_Handle = Selector.GetHandle("addSaveOptionsToView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageProperties = "imageProperties";

	private static readonly IntPtr selImagePropertiesHandle = Selector.GetHandle("imageProperties");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageUTType = "imageUTType";

	private static readonly IntPtr selImageUTTypeHandle = Selector.GetHandle("imageUTType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithImageProperties_ImageUTType_ = "initWithImageProperties:imageUTType:";

	private static readonly IntPtr selInitWithImageProperties_ImageUTType_Handle = Selector.GetHandle("initWithImageProperties:imageUTType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserSelection = "userSelection";

	private static readonly IntPtr selUserSelectionHandle = Selector.GetHandle("userSelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("IKSaveOptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IIKSaveOptionsDelegate Delegate
	{
		get
		{
			return WeakDelegate as IIKSaveOptionsDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary ImageProperties
	{
		[Export("imageProperties")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selImagePropertiesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImagePropertiesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ImageUTType
	{
		[Export("imageUTType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selImageUTTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageUTTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary UserSelection
	{
		[Export("userSelection")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserSelectionHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserSelectionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_IKSaveOptionsDelegate);

	public SaveOptionsShouldShowUTType? ShouldShowType
	{
		get
		{
			return EnsureIKSaveOptionsDelegate().shouldShowType;
		}
		set
		{
			EnsureIKSaveOptionsDelegate().shouldShowType = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKSaveOptions()
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
	protected IKSaveOptions(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal IKSaveOptions(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithImageProperties:imageUTType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IKSaveOptions(NSDictionary imageProperties, string imageUTType)
		: base(NSObjectFlag.Empty)
	{
		if (imageProperties == null)
		{
			throw new ArgumentNullException("imageProperties");
		}
		if (imageUTType == null)
		{
			throw new ArgumentNullException("imageUTType");
		}
		IntPtr arg = NSString.CreateNative(imageUTType);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithImageProperties_ImageUTType_Handle, imageProperties.Handle, arg), "initWithImageProperties:imageUTType:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithImageProperties_ImageUTType_Handle, imageProperties.Handle, arg), "initWithImageProperties:imageUTType:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("addSaveOptionsAccessoryViewToSavePanel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddSaveOptionsToPanel(NSSavePanel savePanel)
	{
		if (savePanel == null)
		{
			throw new ArgumentNullException("savePanel");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddSaveOptionsAccessoryViewToSavePanel_Handle, savePanel.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSaveOptionsAccessoryViewToSavePanel_Handle, savePanel.Handle);
		}
	}

	[Export("addSaveOptionsToView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddSaveOptionsToView(NSView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddSaveOptionsToView_Handle, view.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSaveOptionsToView_Handle, view.Handle);
		}
	}

	internal virtual _IKSaveOptionsDelegate CreateInternalEventDelegateType()
	{
		return new _IKSaveOptionsDelegate();
	}

	internal _IKSaveOptionsDelegate EnsureIKSaveOptionsDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_IKSaveOptionsDelegate iKSaveOptionsDelegate = Delegate as _IKSaveOptionsDelegate;
		if (iKSaveOptionsDelegate == null)
		{
			iKSaveOptionsDelegate = (_IKSaveOptionsDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return iKSaveOptionsDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
