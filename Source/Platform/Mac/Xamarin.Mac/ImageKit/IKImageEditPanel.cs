using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKImageEditPanel", true)]
public class IKImageEditPanel : NSPanel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataSource = "dataSource";

	private static readonly IntPtr selDataSourceHandle = Selector.GetHandle("dataSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterArray = "filterArray";

	private static readonly IntPtr selFilterArrayHandle = Selector.GetHandle("filterArray");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadData = "reloadData";

	private static readonly IntPtr selReloadDataHandle = Selector.GetHandle("reloadData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDataSource_ = "setDataSource:";

	private static readonly IntPtr selSetDataSource_Handle = Selector.GetHandle("setDataSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedImageEditPanel = "sharedImageEditPanel";

	private static readonly IntPtr selSharedImageEditPanelHandle = Selector.GetHandle("sharedImageEditPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("IKImageEditPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_DataSource_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IIKImageEditPanelDataSource? DataSource
	{
		[Export("dataSource", ArgumentSemantic.Assign)]
		get
		{
			IIKImageEditPanelDataSource iIKImageEditPanelDataSource = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IKImageEditPanelDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataSourceHandle), owns: false) : Runtime.GetINativeObject<IKImageEditPanelDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataSourceHandle), owns: false));
			MarkDirty();
			__mt_DataSource_var = iIKImageEditPanelDataSource;
			return iIKImageEditPanelDataSource;
		}
		[Export("setDataSource:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDataSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDataSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_DataSource_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IKImageEditPanel SharedPanel
	{
		[Export("sharedImageEditPanel")]
		get
		{
			return Runtime.GetNSObject<IKImageEditPanel>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedImageEditPanelHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray filterArray
	{
		[Export("filterArray")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selFilterArrayHandle));
			}
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilterArrayHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public IKImageEditPanel(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected IKImageEditPanel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal IKImageEditPanel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("reloadData")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadData()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadDataHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadDataHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_DataSource_var = null;
		}
	}
}
