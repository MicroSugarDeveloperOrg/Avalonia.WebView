using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetReaderOutput", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVAssetReaderOutput : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlwaysCopiesSampleData = "alwaysCopiesSampleData";

	private static readonly IntPtr selAlwaysCopiesSampleDataHandle = Selector.GetHandle("alwaysCopiesSampleData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyNextSampleBuffer = "copyNextSampleBuffer";

	private static readonly IntPtr selCopyNextSampleBufferHandle = Selector.GetHandle("copyNextSampleBuffer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMarkConfigurationAsFinal = "markConfigurationAsFinal";

	private static readonly IntPtr selMarkConfigurationAsFinalHandle = Selector.GetHandle("markConfigurationAsFinal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaType = "mediaType";

	private static readonly IntPtr selMediaTypeHandle = Selector.GetHandle("mediaType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetForReadingTimeRanges_ = "resetForReadingTimeRanges:";

	private static readonly IntPtr selResetForReadingTimeRanges_Handle = Selector.GetHandle("resetForReadingTimeRanges:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlwaysCopiesSampleData_ = "setAlwaysCopiesSampleData:";

	private static readonly IntPtr selSetAlwaysCopiesSampleData_Handle = Selector.GetHandle("setAlwaysCopiesSampleData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSupportsRandomAccess_ = "setSupportsRandomAccess:";

	private static readonly IntPtr selSetSupportsRandomAccess_Handle = Selector.GetHandle("setSupportsRandomAccess:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsRandomAccess = "supportsRandomAccess";

	private static readonly IntPtr selSupportsRandomAccessHandle = Selector.GetHandle("supportsRandomAccess");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAssetReaderOutput");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AlwaysCopiesSampleData
	{
		[Export("alwaysCopiesSampleData")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAlwaysCopiesSampleDataHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAlwaysCopiesSampleDataHandle);
		}
		[Export("setAlwaysCopiesSampleData:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAlwaysCopiesSampleData_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAlwaysCopiesSampleData_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MediaType
	{
		[Export("mediaType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool SupportsRandomAccess
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("supportsRandomAccess")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsRandomAccessHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsRandomAccessHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setSupportsRandomAccess:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSupportsRandomAccess_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSupportsRandomAccess_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAssetReaderOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAssetReaderOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyNextSampleBuffer")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMSampleBuffer? CopyNextSampleBuffer()
	{
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCopyNextSampleBufferHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selCopyNextSampleBufferHandle));
		return (intPtr == IntPtr.Zero) ? null : new CMSampleBuffer(intPtr);
	}

	[Export("markConfigurationAsFinal")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MarkConfigurationAsFinal()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selMarkConfigurationAsFinalHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selMarkConfigurationAsFinalHandle);
		}
	}

	[Export("resetForReadingTimeRanges:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResetForReadingTimeRanges(NSValue[] timeRanges)
	{
		if (timeRanges == null)
		{
			throw new ArgumentNullException("timeRanges");
		}
		NSArray nSArray = NSArray.FromNSObjects(timeRanges);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selResetForReadingTimeRanges_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selResetForReadingTimeRanges_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}
}
