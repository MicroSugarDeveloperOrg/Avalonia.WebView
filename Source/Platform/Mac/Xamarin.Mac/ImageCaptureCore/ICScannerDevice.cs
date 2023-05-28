using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Register("ICScannerDevice", true)]
public class ICScannerDevice : ICDevice
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableFunctionalUnitTypes = "availableFunctionalUnitTypes";

	private static readonly IntPtr selAvailableFunctionalUnitTypesHandle = Selector.GetHandle("availableFunctionalUnitTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelScan = "cancelScan";

	private static readonly IntPtr selCancelScanHandle = Selector.GetHandle("cancelScan");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultUsername = "defaultUsername";

	private static readonly IntPtr selDefaultUsernameHandle = Selector.GetHandle("defaultUsername");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentName = "documentName";

	private static readonly IntPtr selDocumentNameHandle = Selector.GetHandle("documentName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentUTI = "documentUTI";

	private static readonly IntPtr selDocumentUTIHandle = Selector.GetHandle("documentUTI");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDownloadsDirectory = "downloadsDirectory";

	private static readonly IntPtr selDownloadsDirectoryHandle = Selector.GetHandle("downloadsDirectory");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxMemoryBandSize = "maxMemoryBandSize";

	private static readonly IntPtr selMaxMemoryBandSizeHandle = Selector.GetHandle("maxMemoryBandSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestOpenSessionWithCredentials_Password_ = "requestOpenSessionWithCredentials:password:";

	private static readonly IntPtr selRequestOpenSessionWithCredentials_Password_Handle = Selector.GetHandle("requestOpenSessionWithCredentials:password:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestOverviewScan = "requestOverviewScan";

	private static readonly IntPtr selRequestOverviewScanHandle = Selector.GetHandle("requestOverviewScan");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestScan = "requestScan";

	private static readonly IntPtr selRequestScanHandle = Selector.GetHandle("requestScan");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestSelectFunctionalUnit_ = "requestSelectFunctionalUnit:";

	private static readonly IntPtr selRequestSelectFunctionalUnit_Handle = Selector.GetHandle("requestSelectFunctionalUnit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedFunctionalUnit = "selectedFunctionalUnit";

	private static readonly IntPtr selSelectedFunctionalUnitHandle = Selector.GetHandle("selectedFunctionalUnit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultUsername_ = "setDefaultUsername:";

	private static readonly IntPtr selSetDefaultUsername_Handle = Selector.GetHandle("setDefaultUsername:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDocumentName_ = "setDocumentName:";

	private static readonly IntPtr selSetDocumentName_Handle = Selector.GetHandle("setDocumentName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDocumentUTI_ = "setDocumentUTI:";

	private static readonly IntPtr selSetDocumentUTI_Handle = Selector.GetHandle("setDocumentUTI:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDownloadsDirectory_ = "setDownloadsDirectory:";

	private static readonly IntPtr selSetDownloadsDirectory_Handle = Selector.GetHandle("setDownloadsDirectory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxMemoryBandSize_ = "setMaxMemoryBandSize:";

	private static readonly IntPtr selSetMaxMemoryBandSize_Handle = Selector.GetHandle("setMaxMemoryBandSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTransferMode_ = "setTransferMode:";

	private static readonly IntPtr selSetTransferMode_Handle = Selector.GetHandle("setTransferMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransferMode = "transferMode";

	private static readonly IntPtr selTransferModeHandle = Selector.GetHandle("transferMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ICScannerDevice");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[] AvailableFunctionalUnitTypes
	{
		[Export("availableFunctionalUnitTypes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableFunctionalUnitTypesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableFunctionalUnitTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual string DefaultUsername
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("defaultUsername")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultUsernameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultUsernameHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setDefaultUsername:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDefaultUsername_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDefaultUsername_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DocumentName
	{
		[Export("documentName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentNameHandle));
		}
		[Export("setDocumentName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDocumentName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDocumentName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DocumentUti
	{
		[Export("documentUTI")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentUTIHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentUTIHandle));
		}
		[Export("setDocumentUTI:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDocumentUTI_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDocumentUTI_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl DownloadsDirectory
	{
		[Export("downloadsDirectory", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selDownloadsDirectoryHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDownloadsDirectoryHandle));
		}
		[Export("setDownloadsDirectory:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDownloadsDirectory_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDownloadsDirectory_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint MaxMemoryBandSize
	{
		[Export("maxMemoryBandSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selMaxMemoryBandSizeHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selMaxMemoryBandSizeHandle);
		}
		[Export("setMaxMemoryBandSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetMaxMemoryBandSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetMaxMemoryBandSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICScannerFunctionalUnit SelectedFunctionalUnit
	{
		[Export("selectedFunctionalUnit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<ICScannerFunctionalUnit>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedFunctionalUnitHandle));
			}
			return Runtime.GetNSObject<ICScannerFunctionalUnit>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedFunctionalUnitHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICScannerTransferMode TransferMode
	{
		[Export("transferMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (ICScannerTransferMode)Messaging.UInt64_objc_msgSend(base.Handle, selTransferModeHandle);
			}
			return (ICScannerTransferMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTransferModeHandle);
		}
		[Export("setTransferMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTransferMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTransferMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public ICScannerDevice()
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
	protected ICScannerDevice(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ICScannerDevice(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cancelScan")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelScan()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelScanHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelScanHandle);
		}
	}

	[Export("requestOpenSessionWithCredentials:password:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestOpenSession(string username, string password)
	{
		if (username == null)
		{
			throw new ArgumentNullException("username");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		IntPtr arg = NSString.CreateNative(username);
		IntPtr arg2 = NSString.CreateNative(password);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRequestOpenSessionWithCredentials_Password_Handle, arg, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRequestOpenSessionWithCredentials_Password_Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("requestOverviewScan")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestOverviewScan()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRequestOverviewScanHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRequestOverviewScanHandle);
		}
	}

	[Export("requestScan")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestScan()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRequestScanHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRequestScanHandle);
		}
	}

	[Export("requestSelectFunctionalUnit:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestSelectFunctionalUnit(ICScannerFunctionalUnitType type)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selRequestSelectFunctionalUnit_Handle, (ulong)type);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selRequestSelectFunctionalUnit_Handle, (ulong)type);
		}
	}
}
