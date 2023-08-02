using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKImageEditPanel", true)]
public class IKImageEditPanel : NSPanel
{
	private static readonly IntPtr selSharedImageEditPanelHandle = Selector.GetHandle("sharedImageEditPanel");

	private static readonly IntPtr selDataSourceHandle = Selector.GetHandle("dataSource");

	private static readonly IntPtr selSetDataSource_Handle = Selector.GetHandle("setDataSource:");

	private static readonly IntPtr selFilterArrayHandle = Selector.GetHandle("filterArray");

	private static readonly IntPtr selReloadDataHandle = Selector.GetHandle("reloadData");

	private static readonly IntPtr class_ptr = Class.GetHandle("IKImageEditPanel");

	private static object __mt_SharedPanel_var_static;

	private object __mt_DataSource_var;

	private object __mt_filterArray_var;

	public override IntPtr ClassHandle => class_ptr;

	public static IKImageEditPanel SharedPanel
	{
		[Export("sharedImageEditPanel")]
		get
		{
			return (IKImageEditPanel)(__mt_SharedPanel_var_static = (IKImageEditPanel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedImageEditPanelHandle)));
		}
	}

	public virtual IKImageEditPanelDataSource DataSource
	{
		[Export("dataSource", ArgumentSemantic.Assign)]
		get
		{
			return (IKImageEditPanelDataSource)(__mt_DataSource_var = ((!IsDirectBinding) ? ((IKImageEditPanelDataSource)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataSourceHandle))) : ((IKImageEditPanelDataSource)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataSourceHandle)))));
		}
		[Export("setDataSource:", ArgumentSemantic.Assign)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDataSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDataSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_DataSource_var = value;
		}
	}

	public virtual NSArray filterArray
	{
		[Export("filterArray")]
		get
		{
			return (NSArray)(__mt_filterArray_var = ((!IsDirectBinding) ? ((NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilterArrayHandle))) : ((NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFilterArrayHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public IKImageEditPanel(NSCoder coder)
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
	public IKImageEditPanel(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKImageEditPanel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("reloadData")]
	public virtual void ReloadData()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadDataHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadDataHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_DataSource_var = null;
			__mt_filterArray_var = null;
		}
	}
}
