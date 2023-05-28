using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Register("ICScannerBandData", true)]
public class ICScannerBandData : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBitsPerComponent = "bitsPerComponent";

	private static readonly IntPtr selBitsPerComponentHandle = Selector.GetHandle("bitsPerComponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBitsPerPixel = "bitsPerPixel";

	private static readonly IntPtr selBitsPerPixelHandle = Selector.GetHandle("bitsPerPixel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBytesPerRow = "bytesPerRow";

	private static readonly IntPtr selBytesPerRowHandle = Selector.GetHandle("bytesPerRow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorSyncProfilePath = "colorSyncProfilePath";

	private static readonly IntPtr selColorSyncProfilePathHandle = Selector.GetHandle("colorSyncProfilePath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataBuffer = "dataBuffer";

	private static readonly IntPtr selDataBufferHandle = Selector.GetHandle("dataBuffer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataNumRows = "dataNumRows";

	private static readonly IntPtr selDataNumRowsHandle = Selector.GetHandle("dataNumRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataSize = "dataSize";

	private static readonly IntPtr selDataSizeHandle = Selector.GetHandle("dataSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataStartRow = "dataStartRow";

	private static readonly IntPtr selDataStartRowHandle = Selector.GetHandle("dataStartRow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFullImageHeight = "fullImageHeight";

	private static readonly IntPtr selFullImageHeightHandle = Selector.GetHandle("fullImageHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFullImageWidth = "fullImageWidth";

	private static readonly IntPtr selFullImageWidthHandle = Selector.GetHandle("fullImageWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsBigEndian = "isBigEndian";

	private static readonly IntPtr selIsBigEndianHandle = Selector.GetHandle("isBigEndian");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumComponents = "numComponents";

	private static readonly IntPtr selNumComponentsHandle = Selector.GetHandle("numComponents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelDataType = "pixelDataType";

	private static readonly IntPtr selPixelDataTypeHandle = Selector.GetHandle("pixelDataType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ICScannerBandData");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool BigEndian
	{
		[Export("isBigEndian")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsBigEndianHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsBigEndianHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint BitsPerComponent
	{
		[Export("bitsPerComponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selBitsPerComponentHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selBitsPerComponentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint BitsPerPixel
	{
		[Export("bitsPerPixel")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selBitsPerPixelHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selBitsPerPixelHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint BytesPerRow
	{
		[Export("bytesPerRow")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selBytesPerRowHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selBytesPerRowHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? ColorSyncProfilePath
	{
		[Export("colorSyncProfilePath", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selColorSyncProfilePathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSyncProfilePathHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? DataBuffer
	{
		[Export("dataBuffer", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataBufferHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataBufferHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint DataNumRows
	{
		[Export("dataNumRows")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selDataNumRowsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selDataNumRowsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint DataSize
	{
		[Export("dataSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selDataSizeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selDataSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint DataStartRow
	{
		[Export("dataStartRow")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selDataStartRowHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selDataStartRowHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint FullImageHeight
	{
		[Export("fullImageHeight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selFullImageHeightHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selFullImageHeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint FullImageWidth
	{
		[Export("fullImageWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selFullImageWidthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selFullImageWidthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NumComponents
	{
		[Export("numComponents")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumComponentsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumComponentsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICScannerPixelDataType PixelDataType
	{
		[Export("pixelDataType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (ICScannerPixelDataType)Messaging.UInt64_objc_msgSend(base.Handle, selPixelDataTypeHandle);
			}
			return (ICScannerPixelDataType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPixelDataTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public ICScannerBandData()
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
	protected ICScannerBandData(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ICScannerBandData(IntPtr handle)
		: base(handle)
	{
	}
}
