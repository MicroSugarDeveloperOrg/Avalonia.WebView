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
	private sealed class _IKSaveOptionsDelegate : IKSaveOptionsDelegate
	{
		internal SaveOptionsShouldShowUTType shouldShowType;

		[Preserve(Conditional = true)]
		public override bool ShouldShowType(IKSaveOptions saveOptions, string imageUTType)
		{
			return shouldShowType?.Invoke(saveOptions, imageUTType) ?? false;
		}
	}

	private static readonly IntPtr selImagePropertiesHandle = Selector.GetHandle("imageProperties");

	private static readonly IntPtr selImageUTTypeHandle = Selector.GetHandle("imageUTType");

	private static readonly IntPtr selUserSelectionHandle = Selector.GetHandle("userSelection");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selInitWithImagePropertiesImageUTType_Handle = Selector.GetHandle("initWithImageProperties:imageUTType:");

	private static readonly IntPtr selAddSaveOptionsAccessoryViewToSavePanel_Handle = Selector.GetHandle("addSaveOptionsAccessoryViewToSavePanel:");

	private static readonly IntPtr selAddSaveOptionsToView_Handle = Selector.GetHandle("addSaveOptionsToView:");

	private static readonly IntPtr class_ptr = Class.GetHandle("IKSaveOptions");

	private object __mt_ImageProperties_var;

	private object __mt_UserSelection_var;

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSDictionary ImageProperties
	{
		[Export("imageProperties")]
		get
		{
			return (NSDictionary)(__mt_ImageProperties_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImagePropertiesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selImagePropertiesHandle)))));
		}
	}

	public virtual string ImageUTType
	{
		[Export("imageUTType")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selImageUTTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageUTTypeHandle));
		}
	}

	public virtual NSDictionary UserSelection
	{
		[Export("userSelection")]
		get
		{
			return (NSDictionary)(__mt_UserSelection_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserSelectionHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUserSelectionHandle)))));
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public IKSaveOptionsDelegate Delegate
	{
		get
		{
			return WeakDelegate as IKSaveOptionsDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public SaveOptionsShouldShowUTType ShouldShowType
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKSaveOptions()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public IKSaveOptions(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKSaveOptions(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKSaveOptions(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithImageProperties:imageUTType:")]
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
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithImagePropertiesImageUTType_Handle, imageProperties.Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithImagePropertiesImageUTType_Handle, imageProperties.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("addSaveOptionsAccessoryViewToSavePanel:")]
	public virtual void AddSaveOptionsToPanel(NSSavePanel savePanel)
	{
		if (savePanel == null)
		{
			throw new ArgumentNullException("savePanel");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddSaveOptionsAccessoryViewToSavePanel_Handle, savePanel.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSaveOptionsAccessoryViewToSavePanel_Handle, savePanel.Handle);
		}
	}

	[Export("addSaveOptionsToView:")]
	public virtual void AddSaveOptionsToView(NSView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddSaveOptionsToView_Handle, view.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSaveOptionsToView_Handle, view.Handle);
		}
	}

	private _IKSaveOptionsDelegate EnsureIKSaveOptionsDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _IKSaveOptionsDelegate))
		{
			nSObject = (WeakDelegate = new _IKSaveOptionsDelegate());
		}
		return (_IKSaveOptionsDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ImageProperties_var = null;
			__mt_UserSelection_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
