using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSMutableData", true)]
public class NSMutableData : NSData, IEnumerable, IEnumerable<byte>
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendBytes_Length_ = "appendBytes:length:";

	private static readonly IntPtr selAppendBytes_Length_Handle = Selector.GetHandle("appendBytes:length:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendData_ = "appendData:";

	private static readonly IntPtr selAppendData_Handle = Selector.GetHandle("appendData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompressUsingAlgorithm_Error_ = "compressUsingAlgorithm:error:";

	private static readonly IntPtr selCompressUsingAlgorithm_Error_Handle = Selector.GetHandle("compressUsingAlgorithm:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selData = "data";

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataWithCapacity_ = "dataWithCapacity:";

	private static readonly IntPtr selDataWithCapacity_Handle = Selector.GetHandle("dataWithCapacity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataWithLength_ = "dataWithLength:";

	private static readonly IntPtr selDataWithLength_Handle = Selector.GetHandle("dataWithLength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecompressUsingAlgorithm_Error_ = "decompressUsingAlgorithm:error:";

	private static readonly IntPtr selDecompressUsingAlgorithm_Error_Handle = Selector.GetHandle("decompressUsingAlgorithm:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCapacity_ = "initWithCapacity:";

	private static readonly IntPtr selInitWithCapacity_Handle = Selector.GetHandle("initWithCapacity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLength = "length";

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableBytes = "mutableBytes";

	private static readonly IntPtr selMutableBytesHandle = Selector.GetHandle("mutableBytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceBytesInRange_WithBytes_ = "replaceBytesInRange:withBytes:";

	private static readonly IntPtr selReplaceBytesInRange_WithBytes_Handle = Selector.GetHandle("replaceBytesInRange:withBytes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceBytesInRange_WithBytes_Length_ = "replaceBytesInRange:withBytes:length:";

	private static readonly IntPtr selReplaceBytesInRange_WithBytes_Length_Handle = Selector.GetHandle("replaceBytesInRange:withBytes:length:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetBytesInRange_ = "resetBytesInRange:";

	private static readonly IntPtr selResetBytesInRange_Handle = Selector.GetHandle("resetBytesInRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetData_ = "setData:";

	private static readonly IntPtr selSetData_Handle = Selector.GetHandle("setData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLength_ = "setLength:";

	private static readonly IntPtr selSetLength_Handle = Selector.GetHandle("setLength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMutableData");

	public override byte this[nint idx]
	{
		set
		{
			if (idx < 0 || (ulong)idx > (ulong)Length)
			{
				throw new ArgumentException("idx");
			}
			Marshal.WriteByte(new IntPtr(Bytes.ToInt64() + (long)idx), value);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override nuint Length
	{
		[Export("length")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selLengthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selLengthHandle);
		}
		[Export("setLength:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetLength_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetLength_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr MutableBytes
	{
		[Export("mutableBytes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selMutableBytesHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMutableBytesHandle);
		}
	}

	public unsafe void AppendBytes(byte[] bytes)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes");
		}
		fixed (byte* ptr = &bytes[0])
		{
			AppendBytes((IntPtr)ptr, (nuint)bytes.Length);
		}
	}

	public unsafe void AppendBytes(byte[] bytes, nint start, nint len)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes");
		}
		if (start < 0 || start > bytes.Length)
		{
			throw new ArgumentException("start");
		}
		if (start + len > bytes.Length)
		{
			throw new ArgumentException("len");
		}
		fixed (byte* ptr = &bytes[(long)start])
		{
			AppendBytes((IntPtr)ptr, (nuint)len);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		IntPtr source = Bytes;
		nuint top = Length;
		for (nuint i = (byte)0; i < top; ++i)
		{
			if (source == Bytes && top == Length)
			{
				yield return Marshal.ReadByte(source, (int)i);
				continue;
			}
			throw new InvalidOperationException("The NSMutableData has changed");
		}
	}

	IEnumerator<byte> IEnumerable<byte>.GetEnumerator()
	{
		IntPtr source = Bytes;
		nuint top = Length;
		for (nuint i = (byte)0; i < top; ++i)
		{
			if (source == Bytes && top == Length)
			{
				yield return Marshal.ReadByte(source, (int)i);
				continue;
			}
			throw new InvalidOperationException("The NSMutableData has changed");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMutableData()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSMutableData(NSCoder coder)
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
	protected NSMutableData(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMutableData(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCapacity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMutableData(nuint capacity)
		: base(NSObjectFlag.Empty)
	{
		if ((ulong)capacity > (ulong)nint.MaxValue)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selInitWithCapacity_Handle, capacity), "initWithCapacity:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selInitWithCapacity_Handle, capacity), "initWithCapacity:");
		}
	}

	[Export("appendBytes:length:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AppendBytes(IntPtr bytes, nuint len)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, selAppendBytes_Length_Handle, bytes, len);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selAppendBytes_Length_Handle, bytes, len);
		}
	}

	[Export("appendData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AppendData(NSData other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendData_Handle, other.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendData_Handle, other.Handle);
		}
	}

	[Export("compressUsingAlgorithm:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool Compress(NSDataCompressionAlgorithm algorithm, out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_Int64_ref_IntPtr(base.SuperHandle, selCompressUsingAlgorithm_Error_Handle, (long)algorithm, ref arg) : Messaging.bool_objc_msgSend_Int64_ref_IntPtr(base.Handle, selCompressUsingAlgorithm_Error_Handle, (long)algorithm, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("data")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSMutableData Create()
	{
		using (new NSAutoreleasePool())
		{
			return Runtime.GetNSObject<NSMutableData>(Messaging.IntPtr_objc_msgSend(class_ptr, selDataHandle));
		}
	}

	[Export("decompressUsingAlgorithm:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool Decompress(NSDataCompressionAlgorithm algorithm, out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_Int64_ref_IntPtr(base.SuperHandle, selDecompressUsingAlgorithm_Error_Handle, (long)algorithm, ref arg) : Messaging.bool_objc_msgSend_Int64_ref_IntPtr(base.Handle, selDecompressUsingAlgorithm_Error_Handle, (long)algorithm, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("dataWithCapacity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSMutableData FromCapacity(nint capacity)
	{
		using (new NSAutoreleasePool())
		{
			if (capacity < 0 || capacity > nint.MaxValue)
			{
				throw new ArgumentOutOfRangeException();
			}
			return Runtime.GetNSObject<NSMutableData>(Messaging.IntPtr_objc_msgSend_nint(class_ptr, selDataWithCapacity_Handle, capacity));
		}
	}

	[Export("dataWithLength:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSMutableData FromLength(nint length)
	{
		using (new NSAutoreleasePool())
		{
			if (length < 0 || length > nint.MaxValue)
			{
				throw new ArgumentOutOfRangeException();
			}
			return Runtime.GetNSObject<NSMutableData>(Messaging.IntPtr_objc_msgSend_nint(class_ptr, selDataWithLength_Handle, length));
		}
	}

	[Export("replaceBytesInRange:withBytes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceBytes(NSRange range, IntPtr buffer)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_IntPtr(base.Handle, selReplaceBytesInRange_WithBytes_Handle, range, buffer);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selReplaceBytesInRange_WithBytes_Handle, range, buffer);
		}
	}

	[Export("replaceBytesInRange:withBytes:length:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceBytes(NSRange range, IntPtr buffer, nuint length)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_IntPtr_nuint(base.Handle, selReplaceBytesInRange_WithBytes_Length_Handle, range, buffer, length);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_IntPtr_nuint(base.SuperHandle, selReplaceBytesInRange_WithBytes_Length_Handle, range, buffer, length);
		}
	}

	[Export("resetBytesInRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResetBytes(NSRange range)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selResetBytesInRange_Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selResetBytesInRange_Handle, range);
		}
	}

	[Export("setData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetData(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetData_Handle, data.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetData_Handle, data.Handle);
		}
	}
}
