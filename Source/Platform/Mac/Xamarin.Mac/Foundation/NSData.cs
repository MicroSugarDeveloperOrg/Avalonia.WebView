using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using CloudKit;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSData", true)]
public class NSData : NSObject, IEnumerable, IEnumerable<byte>, INSCoding, INativeObject, IDisposable, INSCopying, INSMutableCopying, INSSecureCoding, ICKRecordValue
{
	private class UnmanagedMemoryStreamWithRef : UnmanagedMemoryStream
	{
		protected NSData source;

		public unsafe UnmanagedMemoryStreamWithRef(NSData source)
			: base((byte*)(void*)source.Bytes, (long)source.Length)
		{
			this.source = source;
		}

		protected override void Dispose(bool disposing)
		{
			source = null;
			base.Dispose(disposing);
		}
	}

	private class UnmanagedMemoryStreamWithMutableRef : UnmanagedMemoryStreamWithRef
	{
		private IntPtr base_address;

		public UnmanagedMemoryStreamWithMutableRef(NSData source)
			: base(source)
		{
			base_address = source.Bytes;
		}

		private static void InvalidOperation()
		{
			throw new InvalidOperationException("The underlying NSMutableData changed while we were consuming data");
		}

		public override int Read([In][Out] byte[] buffer, int offset, int count)
		{
			if (base_address != source.Bytes)
			{
				InvalidOperation();
			}
			return base.Read(buffer, offset, count);
		}

		public override int ReadByte()
		{
			if (base_address != source.Bytes)
			{
				InvalidOperation();
			}
			return base.ReadByte();
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			if (base_address != source.Bytes)
			{
				InvalidOperation();
			}
			base.Write(buffer, offset, count);
		}

		public override void WriteByte(byte value)
		{
			if (base_address != source.Bytes)
			{
				InvalidOperation();
			}
			base.WriteByte(value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBase64EncodedDataWithOptions_ = "base64EncodedDataWithOptions:";

	private static readonly IntPtr selBase64EncodedDataWithOptions_Handle = Selector.GetHandle("base64EncodedDataWithOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBase64EncodedStringWithOptions_ = "base64EncodedStringWithOptions:";

	private static readonly IntPtr selBase64EncodedStringWithOptions_Handle = Selector.GetHandle("base64EncodedStringWithOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBytes = "bytes";

	private static readonly IntPtr selBytesHandle = Selector.GetHandle("bytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompressedDataUsingAlgorithm_Error_ = "compressedDataUsingAlgorithm:error:";

	private static readonly IntPtr selCompressedDataUsingAlgorithm_Error_Handle = Selector.GetHandle("compressedDataUsingAlgorithm:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataWithBytes_Length_ = "dataWithBytes:length:";

	private static readonly IntPtr selDataWithBytes_Length_Handle = Selector.GetHandle("dataWithBytes:length:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataWithBytesNoCopy_Length_ = "dataWithBytesNoCopy:length:";

	private static readonly IntPtr selDataWithBytesNoCopy_Length_Handle = Selector.GetHandle("dataWithBytesNoCopy:length:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataWithBytesNoCopy_Length_FreeWhenDone_ = "dataWithBytesNoCopy:length:freeWhenDone:";

	private static readonly IntPtr selDataWithBytesNoCopy_Length_FreeWhenDone_Handle = Selector.GetHandle("dataWithBytesNoCopy:length:freeWhenDone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataWithContentsOfFile_ = "dataWithContentsOfFile:";

	private static readonly IntPtr selDataWithContentsOfFile_Handle = Selector.GetHandle("dataWithContentsOfFile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataWithContentsOfFile_Options_Error_ = "dataWithContentsOfFile:options:error:";

	private static readonly IntPtr selDataWithContentsOfFile_Options_Error_Handle = Selector.GetHandle("dataWithContentsOfFile:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataWithContentsOfURL_ = "dataWithContentsOfURL:";

	private static readonly IntPtr selDataWithContentsOfURL_Handle = Selector.GetHandle("dataWithContentsOfURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataWithContentsOfURL_Options_Error_ = "dataWithContentsOfURL:options:error:";

	private static readonly IntPtr selDataWithContentsOfURL_Options_Error_Handle = Selector.GetHandle("dataWithContentsOfURL:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataWithData_ = "dataWithData:";

	private static readonly IntPtr selDataWithData_Handle = Selector.GetHandle("dataWithData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecompressedDataUsingAlgorithm_Error_ = "decompressedDataUsingAlgorithm:error:";

	private static readonly IntPtr selDecompressedDataUsingAlgorithm_Error_Handle = Selector.GetHandle("decompressedDataUsingAlgorithm:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateByteRangesUsingBlock_ = "enumerateByteRangesUsingBlock:";

	private static readonly IntPtr selEnumerateByteRangesUsingBlock_Handle = Selector.GetHandle("enumerateByteRangesUsingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetBytes_Length_ = "getBytes:length:";

	private static readonly IntPtr selGetBytes_Length_Handle = Selector.GetHandle("getBytes:length:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetBytes_Range_ = "getBytes:range:";

	private static readonly IntPtr selGetBytes_Range_Handle = Selector.GetHandle("getBytes:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBase64EncodedData_Options_ = "initWithBase64EncodedData:options:";

	private static readonly IntPtr selInitWithBase64EncodedData_Options_Handle = Selector.GetHandle("initWithBase64EncodedData:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBase64EncodedString_Options_ = "initWithBase64EncodedString:options:";

	private static readonly IntPtr selInitWithBase64EncodedString_Options_Handle = Selector.GetHandle("initWithBase64EncodedString:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBytesNoCopy_Length_Deallocator_ = "initWithBytesNoCopy:length:deallocator:";

	private static readonly IntPtr selInitWithBytesNoCopy_Length_Deallocator_Handle = Selector.GetHandle("initWithBytesNoCopy:length:deallocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLength = "length";

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableCopyWithZone_ = "mutableCopyWithZone:";

	private static readonly IntPtr selMutableCopyWithZone_Handle = Selector.GetHandle("mutableCopyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeOfData_Options_Range_ = "rangeOfData:options:range:";

	private static readonly IntPtr selRangeOfData_Options_Range_Handle = Selector.GetHandle("rangeOfData:options:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubdataWithRange_ = "subdataWithRange:";

	private static readonly IntPtr selSubdataWithRange_Handle = Selector.GetHandle("subdataWithRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToFile_Atomically_ = "writeToFile:atomically:";

	private static readonly IntPtr selWriteToFile_Atomically_Handle = Selector.GetHandle("writeToFile:atomically:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToFile_Options_Error_ = "writeToFile:options:error:";

	private static readonly IntPtr selWriteToFile_Options_Error_Handle = Selector.GetHandle("writeToFile:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToURL_Atomically_ = "writeToURL:atomically:";

	private static readonly IntPtr selWriteToURL_Atomically_Handle = Selector.GetHandle("writeToURL:atomically:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToURL_Options_Error_ = "writeToURL:options:error:";

	private static readonly IntPtr selWriteToURL_Options_Error_Handle = Selector.GetHandle("writeToURL:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSData");

	public virtual byte this[nint idx]
	{
		get
		{
			if (idx < 0 || (ulong)idx > (ulong)Length)
			{
				throw new ArgumentException("idx");
			}
			return Marshal.ReadByte(new IntPtr(Bytes.ToInt64() + (long)idx));
		}
		set
		{
			throw new NotImplementedException("NSData arrays can not be modified, use an NSMutableData instead");
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr Bytes
	{
		[Export("bytes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selBytesHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBytesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Length
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
		[NotImplemented("Not available on NSData, only available on NSMutableData")]
		set
		{
			throw new NotImplementedException("Not available on NSData, only available on NSMutableData");
		}
	}

	internal NSData(IntPtr handle, bool owns)
		: base(handle)
	{
		if (!owns)
		{
			DangerousRelease();
		}
	}

	public byte[] ToArray()
	{
		byte[] array = new byte[(ulong)Length];
		if (Length > (byte)0)
		{
			Marshal.Copy(Bytes, array, 0, array.Length);
		}
		return array;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		IntPtr source = Bytes;
		nuint top = Length;
		for (nuint i = (byte)0; i < top; ++i)
		{
			yield return Marshal.ReadByte(source, (int)i);
		}
	}

	IEnumerator<byte> IEnumerable<byte>.GetEnumerator()
	{
		IntPtr source = Bytes;
		nuint top = Length;
		for (nuint i = (byte)0; i < top; ++i)
		{
			yield return Marshal.ReadByte(source, (int)i);
		}
	}

	public static NSData FromString(string s)
	{
		return FromString(s, NSStringEncoding.UTF8);
	}

	public unsafe static NSData FromArray(byte[] buffer)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (buffer.Length == 0)
		{
			return FromBytes(IntPtr.Zero, (byte)0);
		}
		fixed (byte* ptr = &buffer[0])
		{
			return FromBytes((IntPtr)ptr, (nuint)buffer.Length);
		}
	}

	public unsafe static NSData FromStream(Stream stream)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (!stream.CanRead)
		{
			return null;
		}
		long num = 8192L;
		if (stream.CanSeek)
		{
			try
			{
				num = stream.Length - stream.Position;
			}
			catch
			{
			}
		}
		NSMutableData nSMutableData = NSMutableData.FromCapacity((int)num);
		byte[] array = new byte[32768];
		try
		{
			try
			{
				fixed (byte* ptr = &array[0])
				{
					int num2;
					while ((num2 = stream.Read(array, 0, array.Length)) != 0)
					{
						nSMutableData.AppendBytes((IntPtr)ptr, (nuint)num2);
					}
				}
			}
			finally
			{
			}
		}
		catch
		{
			return null;
		}
		return nSMutableData;
	}

	public virtual Stream AsStream()
	{
		if (this is NSMutableData)
		{
			return new UnmanagedMemoryStreamWithMutableRef(this);
		}
		return new UnmanagedMemoryStreamWithRef(this);
	}

	public static NSData FromString(string s, NSStringEncoding encoding)
	{
		using NSString nSString = new NSString(s);
		return nSString.Encode(encoding);
	}

	public static implicit operator NSData(string s)
	{
		return FromString(s, NSStringEncoding.UTF8);
	}

	public NSString ToString(NSStringEncoding encoding)
	{
		return new NSString(this, encoding);
	}

	public override string ToString()
	{
		try
		{
			using NSString nSString = new NSString(this, NSStringEncoding.UTF8);
			return nSString.ToString();
		}
		catch
		{
			return Description;
		}
	}

	public bool Save(string file, bool auxiliaryFile, out NSError error)
	{
		return Save(file, (NSDataWritingOptions)(auxiliaryFile ? 1 : 0), out error);
	}

	public unsafe bool Save(string file, NSDataWritingOptions options, out NSError error)
	{
		IntPtr ptr = default(IntPtr);
		IntPtr addr = (IntPtr)(&ptr);
		bool result = _Save(file, (nint)(long)options, addr);
		error = (NSError)Runtime.GetNSObject(ptr);
		return result;
	}

	public bool Save(NSUrl url, bool auxiliaryFile, out NSError error)
	{
		return Save(url, (NSDataWritingOptions)(auxiliaryFile ? 1 : 0), out error);
	}

	public unsafe bool Save(NSUrl url, NSDataWritingOptions options, out NSError error)
	{
		IntPtr ptr = default(IntPtr);
		IntPtr addr = (IntPtr)(&ptr);
		bool result = _Save(url, (nint)(long)options, addr);
		error = (NSError)Runtime.GetNSObject(ptr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSData()
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
	public NSData(NSCoder coder)
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
	protected NSData(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSData(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithBase64EncodedString:options:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSData(string base64String, NSDataBase64DecodingOptions options)
		: base(NSObjectFlag.Empty)
	{
		if (base64String == null)
		{
			throw new ArgumentNullException("base64String");
		}
		IntPtr arg = NSString.CreateNative(base64String);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selInitWithBase64EncodedString_Options_Handle, arg, (ulong)options), "initWithBase64EncodedString:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selInitWithBase64EncodedString_Options_Handle, arg, (ulong)options), "initWithBase64EncodedString:options:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithBase64EncodedData:options:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSData(NSData base64Data, NSDataBase64DecodingOptions options)
		: base(NSObjectFlag.Empty)
	{
		if (base64Data == null)
		{
			throw new ArgumentNullException("base64Data");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selInitWithBase64EncodedData_Options_Handle, base64Data.Handle, (ulong)options), "initWithBase64EncodedData:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selInitWithBase64EncodedData_Options_Handle, base64Data.Handle, (ulong)options), "initWithBase64EncodedData:options:");
		}
	}

	[Export("initWithBytesNoCopy:length:deallocator:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe NSData(IntPtr bytes, nuint length, [BlockProxy(typeof(Trampolines.NIDActionArity2V40))] Action<IntPtr, nuint> deallocator)
		: base(NSObjectFlag.Empty)
	{
		if (deallocator == null)
		{
			throw new ArgumentNullException("deallocator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V40.Handler, deallocator);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_IntPtr(base.Handle, selInitWithBytesNoCopy_Length_Deallocator_Handle, bytes, length, (IntPtr)ptr), "initWithBytesNoCopy:length:deallocator:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_IntPtr(base.SuperHandle, selInitWithBytesNoCopy_Length_Deallocator_Handle, bytes, length, (IntPtr)ptr), "initWithBytesNoCopy:length:deallocator:");
		}
		ptr->CleanupBlock();
	}

	[Export("compressedDataUsingAlgorithm:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? Compress(NSDataCompressionAlgorithm algorithm, out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		NSData result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_Int64_ref_IntPtr(base.SuperHandle, selCompressedDataUsingAlgorithm_Error_Handle, (long)algorithm, ref arg)) : Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_Int64_ref_IntPtr(base.Handle, selCompressedDataUsingAlgorithm_Error_Handle, (long)algorithm, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("decompressedDataUsingAlgorithm:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? Decompress(NSDataCompressionAlgorithm algorithm, out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		NSData result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_Int64_ref_IntPtr(base.SuperHandle, selDecompressedDataUsingAlgorithm_Error_Handle, (long)algorithm, ref arg)) : Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_Int64_ref_IntPtr(base.Handle, selDecompressedDataUsingAlgorithm_Error_Handle, (long)algorithm, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("enumerateByteRangesUsingBlock:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateByteRange([BlockProxy(typeof(Trampolines.NIDNSDataByteRangeEnumerator))] NSDataByteRangeEnumerator enumerator)
	{
		if (enumerator == null)
		{
			throw new ArgumentNullException("enumerator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSDataByteRangeEnumerator.Handler, enumerator);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEnumerateByteRangesUsingBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEnumerateByteRangesUsingBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("rangeOfData:options:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange Find(NSData dataToFind, NSDataSearchOptions searchOptions, NSRange searchRange)
	{
		if (dataToFind == null)
		{
			throw new ArgumentNullException("dataToFind");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_IntPtr_UInt64_NSRange(base.Handle, selRangeOfData_Options_Range_Handle, dataToFind.Handle, (ulong)searchOptions, searchRange);
		}
		return Messaging.NSRange_objc_msgSendSuper_IntPtr_UInt64_NSRange(base.SuperHandle, selRangeOfData_Options_Range_Handle, dataToFind.Handle, (ulong)searchOptions, searchRange);
	}

	[Export("dataWithBytes:length:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData FromBytes(IntPtr bytes, nuint size)
	{
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(class_ptr, selDataWithBytes_Length_Handle, bytes, size));
	}

	[Export("dataWithBytesNoCopy:length:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData FromBytesNoCopy(IntPtr bytes, nuint size)
	{
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(class_ptr, selDataWithBytesNoCopy_Length_Handle, bytes, size));
	}

	[Export("dataWithBytesNoCopy:length:freeWhenDone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData FromBytesNoCopy(IntPtr bytes, nuint size, bool freeWhenDone)
	{
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_bool(class_ptr, selDataWithBytesNoCopy_Length_FreeWhenDone_Handle, bytes, size, freeWhenDone));
	}

	[Export("dataWithData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData FromData(NSData source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDataWithData_Handle, source.Handle));
	}

	[Export("dataWithContentsOfFile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData FromFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSData nSObject = Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDataWithContentsOfFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("dataWithContentsOfFile:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData FromFile(string path, NSDataReadingOptions mask, out NSError error)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(path);
		NSData nSObject = Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_ref_IntPtr(class_ptr, selDataWithContentsOfFile_Options_Error_Handle, arg2, (ulong)mask, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("dataWithContentsOfURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData FromUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDataWithContentsOfURL_Handle, url.Handle));
	}

	[Export("dataWithContentsOfURL:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData FromUrl(NSUrl url, NSDataReadingOptions mask, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		NSData nSObject = Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_ref_IntPtr(class_ptr, selDataWithContentsOfURL_Options_Error_Handle, url.Handle, (ulong)mask, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("base64EncodedDataWithOptions:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData GetBase64EncodedData(NSDataBase64EncodingOptions options)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selBase64EncodedDataWithOptions_Handle, (ulong)options));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selBase64EncodedDataWithOptions_Handle, (ulong)options));
	}

	[Export("base64EncodedStringWithOptions:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetBase64EncodedString(NSDataBase64EncodingOptions options)
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selBase64EncodedStringWithOptions_Handle, (ulong)options));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selBase64EncodedStringWithOptions_Handle, (ulong)options));
	}

	[Export("getBytes:length:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetBytes(IntPtr buffer, nuint length)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, selGetBytes_Length_Handle, buffer, length);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selGetBytes_Length_Handle, buffer, length);
		}
	}

	[Export("getBytes:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetBytes(IntPtr buffer, NSRange range)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selGetBytes_Range_Handle, buffer, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selGetBytes_Range_Handle, buffer, range);
		}
	}

	[Export("mutableCopyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject MutableCopy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("writeToFile:atomically:")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'Save (NSUrl,bool)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'Save (NSUrl,bool)' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'Save (NSUrl,bool)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'Save (NSUrl,bool)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Save(string path, bool atomically)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selWriteToFile_Atomically_Handle, arg, atomically) : Messaging.bool_objc_msgSend_IntPtr_bool(base.Handle, selWriteToFile_Atomically_Handle, arg, atomically));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("writeToURL:atomically:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Save(NSUrl url, bool atomically)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_bool(base.Handle, selWriteToURL_Atomically_Handle, url.Handle, atomically);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selWriteToURL_Atomically_Handle, url.Handle, atomically);
	}

	[Export("subdataWithRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData Subdata(NSRange range)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selSubdataWithRange_Handle, range));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selSubdataWithRange_Handle, range));
	}

	[Export("writeToFile:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual bool _Save(string file, nint options, IntPtr addr)
	{
		if (file == null)
		{
			throw new ArgumentNullException("file");
		}
		IntPtr arg = NSString.CreateNative(file);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_nint_IntPtr(base.SuperHandle, selWriteToFile_Options_Error_Handle, arg, options, addr) : Messaging.bool_objc_msgSend_IntPtr_nint_IntPtr(base.Handle, selWriteToFile_Options_Error_Handle, arg, options, addr));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("writeToURL:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual bool _Save(NSUrl url, nint options, IntPtr addr)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_nint_IntPtr(base.Handle, selWriteToURL_Options_Error_Handle, url.Handle, options, addr);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_nint_IntPtr(base.SuperHandle, selWriteToURL_Options_Error_Handle, url.Handle, options, addr);
	}
}
