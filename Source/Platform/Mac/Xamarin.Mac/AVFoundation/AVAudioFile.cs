using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioFile", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVAudioFile : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileFormat = "fileFormat";

	private static readonly IntPtr selFileFormatHandle = Selector.GetHandle("fileFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFramePosition = "framePosition";

	private static readonly IntPtr selFramePositionHandle = Selector.GetHandle("framePosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitForReading_CommonFormat_Interleaved_Error_ = "initForReading:commonFormat:interleaved:error:";

	private static readonly IntPtr selInitForReading_CommonFormat_Interleaved_Error_Handle = Selector.GetHandle("initForReading:commonFormat:interleaved:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitForReading_Error_ = "initForReading:error:";

	private static readonly IntPtr selInitForReading_Error_Handle = Selector.GetHandle("initForReading:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitForWriting_Settings_CommonFormat_Interleaved_Error_ = "initForWriting:settings:commonFormat:interleaved:error:";

	private static readonly IntPtr selInitForWriting_Settings_CommonFormat_Interleaved_Error_Handle = Selector.GetHandle("initForWriting:settings:commonFormat:interleaved:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitForWriting_Settings_Error_ = "initForWriting:settings:error:";

	private static readonly IntPtr selInitForWriting_Settings_Error_Handle = Selector.GetHandle("initForWriting:settings:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLength = "length";

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProcessingFormat = "processingFormat";

	private static readonly IntPtr selProcessingFormatHandle = Selector.GetHandle("processingFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadIntoBuffer_Error_ = "readIntoBuffer:error:";

	private static readonly IntPtr selReadIntoBuffer_Error_Handle = Selector.GetHandle("readIntoBuffer:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadIntoBuffer_FrameCount_Error_ = "readIntoBuffer:frameCount:error:";

	private static readonly IntPtr selReadIntoBuffer_FrameCount_Error_Handle = Selector.GetHandle("readIntoBuffer:frameCount:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFramePosition_ = "setFramePosition:";

	private static readonly IntPtr selSetFramePosition_Handle = Selector.GetHandle("setFramePosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUrl = "url";

	private static readonly IntPtr selUrlHandle = Selector.GetHandle("url");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteFromBuffer_Error_ = "writeFromBuffer:error:";

	private static readonly IntPtr selWriteFromBuffer_Error_Handle = Selector.GetHandle("writeFromBuffer:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioFile");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioFormat FileFormat
	{
		[Export("fileFormat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioFormat>(Messaging.IntPtr_objc_msgSend(base.Handle, selFileFormatHandle));
			}
			return Runtime.GetNSObject<AVAudioFormat>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileFormatHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long FramePosition
	{
		[Export("framePosition")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selFramePositionHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFramePositionHandle);
		}
		[Export("setFramePosition:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetFramePosition_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetFramePosition_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long Length
	{
		[Export("length")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selLengthHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selLengthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioFormat ProcessingFormat
	{
		[Export("processingFormat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioFormat>(Messaging.IntPtr_objc_msgSend(base.Handle, selProcessingFormatHandle));
			}
			return Runtime.GetNSObject<AVAudioFormat>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProcessingFormatHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl Url
	{
		[Export("url")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selUrlHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUrlHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVAudioFile()
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
	protected AVAudioFile(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioFile(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initForReading:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioFile(NSUrl fileUrl, out NSError outError)
		: base(NSObjectFlag.Empty)
	{
		if (fileUrl == null)
		{
			throw new ArgumentNullException("fileUrl");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitForReading_Error_Handle, fileUrl.Handle, ref arg), "initForReading:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitForReading_Error_Handle, fileUrl.Handle, ref arg), "initForReading:error:");
		}
		outError = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initForReading:commonFormat:interleaved:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioFile(NSUrl fileUrl, AVAudioCommonFormat format, bool interleaved, out NSError outError)
		: base(NSObjectFlag.Empty)
	{
		if (fileUrl == null)
		{
			throw new ArgumentNullException("fileUrl");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_bool_ref_IntPtr(base.Handle, selInitForReading_CommonFormat_Interleaved_Error_Handle, fileUrl.Handle, (ulong)format, interleaved, ref arg), "initForReading:commonFormat:interleaved:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_bool_ref_IntPtr(base.SuperHandle, selInitForReading_CommonFormat_Interleaved_Error_Handle, fileUrl.Handle, (ulong)format, interleaved, ref arg), "initForReading:commonFormat:interleaved:error:");
		}
		outError = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initForWriting:settings:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal AVAudioFile(NSUrl fileUrl, NSDictionary settings, out NSError outError)
		: base(NSObjectFlag.Empty)
	{
		if (fileUrl == null)
		{
			throw new ArgumentNullException("fileUrl");
		}
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selInitForWriting_Settings_Error_Handle, fileUrl.Handle, settings.Handle, ref arg), "initForWriting:settings:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selInitForWriting_Settings_Error_Handle, fileUrl.Handle, settings.Handle, ref arg), "initForWriting:settings:error:");
		}
		outError = Runtime.GetNSObject<NSError>(arg);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioFile(NSUrl fileUrl, AudioSettings settings, out NSError outError)
		: this(fileUrl, settings.GetDictionary(), out outError)
	{
	}

	[Export("initForWriting:settings:commonFormat:interleaved:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal AVAudioFile(NSUrl fileUrl, NSDictionary settings, AVAudioCommonFormat format, bool interleaved, out NSError outError)
		: base(NSObjectFlag.Empty)
	{
		if (fileUrl == null)
		{
			throw new ArgumentNullException("fileUrl");
		}
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_bool_ref_IntPtr(base.Handle, selInitForWriting_Settings_CommonFormat_Interleaved_Error_Handle, fileUrl.Handle, settings.Handle, (ulong)format, interleaved, ref arg), "initForWriting:settings:commonFormat:interleaved:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_bool_ref_IntPtr(base.SuperHandle, selInitForWriting_Settings_CommonFormat_Interleaved_Error_Handle, fileUrl.Handle, settings.Handle, (ulong)format, interleaved, ref arg), "initForWriting:settings:commonFormat:interleaved:error:");
		}
		outError = Runtime.GetNSObject<NSError>(arg);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioFile(NSUrl fileUrl, AudioSettings settings, AVAudioCommonFormat format, bool interleaved, out NSError outError)
		: this(fileUrl, settings.GetDictionary(), format, interleaved, out outError)
	{
	}

	[Export("readIntoBuffer:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReadIntoBuffer(AVAudioPcmBuffer buffer, out NSError outError)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selReadIntoBuffer_Error_Handle, buffer.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selReadIntoBuffer_Error_Handle, buffer.Handle, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("readIntoBuffer:frameCount:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReadIntoBuffer(AVAudioPcmBuffer buffer, uint frames, out NSError outError)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_UInt32_ref_IntPtr(base.SuperHandle, selReadIntoBuffer_FrameCount_Error_Handle, buffer.Handle, frames, ref arg) : Messaging.bool_objc_msgSend_IntPtr_UInt32_ref_IntPtr(base.Handle, selReadIntoBuffer_FrameCount_Error_Handle, buffer.Handle, frames, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("writeFromBuffer:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteFromBuffer(AVAudioPcmBuffer buffer, out NSError outError)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selWriteFromBuffer_Error_Handle, buffer.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selWriteFromBuffer_Error_Handle, buffer.Handle, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
