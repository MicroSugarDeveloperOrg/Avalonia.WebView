using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Register("ICDevice", true)]
public class ICDevice : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUUIDString = "UUIDString";

	private static readonly IntPtr selUUIDStringHandle = Selector.GetHandle("UUIDString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutolaunchApplicationPath = "autolaunchApplicationPath";

	private static readonly IntPtr selAutolaunchApplicationPathHandle = Selector.GetHandle("autolaunchApplicationPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButtonPressed = "buttonPressed";

	private static readonly IntPtr selButtonPressedHandle = Selector.GetHandle("buttonPressed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCapabilities = "capabilities";

	private static readonly IntPtr selCapabilitiesHandle = Selector.GetHandle("capabilities");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFwGUID = "fwGUID";

	private static readonly IntPtr selFwGUIDHandle = Selector.GetHandle("fwGUID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasConfigurableWiFiInterface = "hasConfigurableWiFiInterface";

	private static readonly IntPtr selHasConfigurableWiFiInterfaceHandle = Selector.GetHandle("hasConfigurableWiFiInterface");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasOpenSession = "hasOpenSession";

	private static readonly IntPtr selHasOpenSessionHandle = Selector.GetHandle("hasOpenSession");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIcon = "icon";

	private static readonly IntPtr selIconHandle = Selector.GetHandle("icon");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRemote = "isRemote";

	private static readonly IntPtr selIsRemoteHandle = Selector.GetHandle("isRemote");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsShared = "isShared";

	private static readonly IntPtr selIsSharedHandle = Selector.GetHandle("isShared");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocationDescription = "locationDescription";

	private static readonly IntPtr selLocationDescriptionHandle = Selector.GetHandle("locationDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModuleExecutableArchitecture = "moduleExecutableArchitecture";

	private static readonly IntPtr selModuleExecutableArchitectureHandle = Selector.GetHandle("moduleExecutableArchitecture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModulePath = "modulePath";

	private static readonly IntPtr selModulePathHandle = Selector.GetHandle("modulePath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModuleVersion = "moduleVersion";

	private static readonly IntPtr selModuleVersionHandle = Selector.GetHandle("moduleVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPersistentIDString = "persistentIDString";

	private static readonly IntPtr selPersistentIDStringHandle = Selector.GetHandle("persistentIDString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestCloseSession = "requestCloseSession";

	private static readonly IntPtr selRequestCloseSessionHandle = Selector.GetHandle("requestCloseSession");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestEjectOrDisconnect = "requestEjectOrDisconnect";

	private static readonly IntPtr selRequestEjectOrDisconnectHandle = Selector.GetHandle("requestEjectOrDisconnect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestOpenSession = "requestOpenSession";

	private static readonly IntPtr selRequestOpenSessionHandle = Selector.GetHandle("requestOpenSession");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestSendMessage_OutData_MaxReturnedDataSize_SendMessageDelegate_DidSendMessageSelector_ContextInfo_ = "requestSendMessage:outData:maxReturnedDataSize:sendMessageDelegate:didSendMessageSelector:contextInfo:";

	private static readonly IntPtr selRequestSendMessage_OutData_MaxReturnedDataSize_SendMessageDelegate_DidSendMessageSelector_ContextInfo_Handle = Selector.GetHandle("requestSendMessage:outData:maxReturnedDataSize:sendMessageDelegate:didSendMessageSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestYield = "requestYield";

	private static readonly IntPtr selRequestYieldHandle = Selector.GetHandle("requestYield");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSerialNumberString = "serialNumberString";

	private static readonly IntPtr selSerialNumberStringHandle = Selector.GetHandle("serialNumberString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutolaunchApplicationPath_ = "setAutolaunchApplicationPath:";

	private static readonly IntPtr selSetAutolaunchApplicationPath_Handle = Selector.GetHandle("setAutolaunchApplicationPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransportType = "transportType";

	private static readonly IntPtr selTransportTypeHandle = Selector.GetHandle("transportType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsbLocationID = "usbLocationID";

	private static readonly IntPtr selUsbLocationIDHandle = Selector.GetHandle("usbLocationID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsbProductID = "usbProductID";

	private static readonly IntPtr selUsbProductIDHandle = Selector.GetHandle("usbProductID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsbVendorID = "usbVendorID";

	private static readonly IntPtr selUsbVendorIDHandle = Selector.GetHandle("usbVendorID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserData = "userData";

	private static readonly IntPtr selUserDataHandle = Selector.GetHandle("userData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ICDevice");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? AutolaunchApplicationPath
	{
		[Export("autolaunchApplicationPath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAutolaunchApplicationPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAutolaunchApplicationPathHandle));
		}
		[Export("setAutolaunchApplicationPath:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAutolaunchApplicationPath_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAutolaunchApplicationPath_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ButtonPressed
	{
		[Export("buttonPressed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selButtonPressedHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selButtonPressedHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString[] Capabilities
	{
		[Export("capabilities")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selCapabilitiesHandle));
			}
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCapabilitiesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IICDeviceDelegate? Delegate
	{
		get
		{
			return WeakDelegate as IICDeviceDelegate;
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
	public virtual long FireWireGuid
	{
		[Export("fwGUID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selFwGUIDHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFwGUIDHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	public virtual bool HasConfigurableWiFiInterface
	{
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
		[Export("hasConfigurableWiFiInterface")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasConfigurableWiFiInterfaceHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasConfigurableWiFiInterfaceHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasOpenSession
	{
		[Export("hasOpenSession")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasOpenSessionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasOpenSessionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGImage? Icon
	{
		[Export("icon")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIconHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selIconHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGImage(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? LocationDescription
	{
		[Export("locationDescription")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocationDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocationDescriptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int ModuleExecutableArchitecture
	{
		[Export("moduleExecutableArchitecture")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selModuleExecutableArchitectureHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selModuleExecutableArchitectureHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ModulePath
	{
		[Export("modulePath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selModulePathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selModulePathHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ModuleVersion
	{
		[Export("moduleVersion")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selModuleVersionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selModuleVersionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Name
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? PersistentId
	{
		[Export("persistentIDString")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPersistentIDStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPersistentIDStringHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Remote
	{
		[Export("isRemote")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRemoteHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRemoteHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? SerialNumber
	{
		[Export("serialNumberString")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSerialNumberStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSerialNumberStringHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	public virtual bool Shared
	{
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
		[Export("isShared")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSharedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSharedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[BindAs(typeof(ICTransportType), OriginalType = typeof(NSString))]
	public virtual ICTransportType TransportType
	{
		[Export("transportType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return ICTransportTypeExtensions.GetValue(Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selTransportTypeHandle)));
			}
			return ICTransportTypeExtensions.GetValue(Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTransportTypeHandle)));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICDeviceType Type
	{
		[Export("type")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (ICDeviceType)Messaging.UInt64_objc_msgSend(base.Handle, selTypeHandle);
			}
			return (ICDeviceType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int UsbLocationId
	{
		[Export("usbLocationID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selUsbLocationIDHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selUsbLocationIDHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int UsbProductId
	{
		[Export("usbProductID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selUsbProductIDHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selUsbProductIDHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int UsbVendorId
	{
		[Export("usbVendorID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selUsbVendorIDHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selUsbVendorIDHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMutableDictionary? UserData
	{
		[Export("userData")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserDataHandle));
			}
			return Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Uuid
	{
		[Export("UUIDString")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUUIDStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUUIDStringHandle));
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public ICDevice()
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
	protected ICDevice(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ICDevice(IntPtr handle)
		: base(handle)
	{
	}

	[Export("requestCloseSession")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestCloseSession()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRequestCloseSessionHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRequestCloseSessionHandle);
		}
	}

	[Export("requestEjectOrDisconnect")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestEjectOrDisconnect()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRequestEjectOrDisconnectHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRequestEjectOrDisconnectHandle);
		}
	}

	[Export("requestOpenSession")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestOpenSession()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRequestOpenSessionHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRequestOpenSessionHandle);
		}
	}

	[Export("requestSendMessage:outData:maxReturnedDataSize:sendMessageDelegate:didSendMessageSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestSendMessage(uint messageCode, NSData data, uint maxReturnedDataSize, NSObject sendMessageDelegate, Selector selector, IntPtr contextInfo)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (sendMessageDelegate == null)
		{
			throw new ArgumentNullException("sendMessageDelegate");
		}
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32_IntPtr_UInt32_IntPtr_IntPtr_IntPtr(base.Handle, selRequestSendMessage_OutData_MaxReturnedDataSize_SendMessageDelegate_DidSendMessageSelector_ContextInfo_Handle, messageCode, data.Handle, maxReturnedDataSize, sendMessageDelegate.Handle, selector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32_IntPtr_UInt32_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRequestSendMessage_OutData_MaxReturnedDataSize_SendMessageDelegate_DidSendMessageSelector_ContextInfo_Handle, messageCode, data.Handle, maxReturnedDataSize, sendMessageDelegate.Handle, selector.Handle, contextInfo);
		}
	}

	[Export("requestYield")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestYield()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRequestYieldHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRequestYieldHandle);
		}
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
