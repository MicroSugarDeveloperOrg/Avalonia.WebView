using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Foundation;

[Register("NSData", true)]
public class NSData : NSObject, IEnumerable, IEnumerable<byte>
{
	private class UnmanagedMemoryStreamWithRef : UnmanagedMemoryStream
	{
		private NSData source;

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
		private NSData source;

		private IntPtr base_address;

		public UnmanagedMemoryStreamWithMutableRef(NSData source)
			: base(source)
		{
			base_address = source.Bytes;
			this.source = source;
		}

		protected override void Dispose(bool disposing)
		{
			source = null;
			base.Dispose(disposing);
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

	private static readonly IntPtr selBytesHandle = Selector.GetHandle("bytes");

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	private static readonly IntPtr selSetLength_Handle = Selector.GetHandle("setLength:");

	private static readonly IntPtr selDataWithContentsOfURL_Handle = Selector.GetHandle("dataWithContentsOfURL:");

	private static readonly IntPtr selDataWithContentsOfURLOptionsError_Handle = Selector.GetHandle("dataWithContentsOfURL:options:error:");

	private static readonly IntPtr selDataWithContentsOfFile_Handle = Selector.GetHandle("dataWithContentsOfFile:");

	private static readonly IntPtr selDataWithContentsOfFileOptionsError_Handle = Selector.GetHandle("dataWithContentsOfFile:options:error:");

	private static readonly IntPtr selDataWithData_Handle = Selector.GetHandle("dataWithData:");

	private static readonly IntPtr selDataWithBytesLength_Handle = Selector.GetHandle("dataWithBytes:length:");

	private static readonly IntPtr selWriteToFileOptionsError_Handle = Selector.GetHandle("writeToFile:options:error:");

	private static readonly IntPtr selWriteToURLOptionsError_Handle = Selector.GetHandle("writeToURL:options:error:");

	private static readonly IntPtr selRangeOfDataOptionsRange_Handle = Selector.GetHandle("rangeOfData:options:range:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSData");

	public virtual byte this[int idx]
	{
		get
		{
			if (idx < 0 || idx >= int.MaxValue || idx > (int)Length)
			{
				throw new ArgumentException("idx");
			}
			return Marshal.ReadByte(Bytes, idx);
		}
		set
		{
			throw new NotImplementedException("NSData arrays can not be modified, use an NSMUtableData instead");
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public virtual IntPtr Bytes
	{
		[Export("bytes")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selBytesHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBytesHandle);
		}
	}

	public virtual ulong Length
	{
		[Export("length")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selLengthHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLengthHandle);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	internal NSData(IntPtr handle, bool owns)
		: base(handle)
	{
		if (!owns)
		{
			Release();
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		IntPtr source = Bytes;
		int top = (int)Length;
		for (int i = 0; i < top; i++)
		{
			yield return Marshal.ReadByte(source, i);
		}
	}

	IEnumerator<byte> IEnumerable<byte>.GetEnumerator()
	{
		IntPtr source = Bytes;
		int top = (int)Length;
		for (int i = 0; i < top; i++)
		{
			yield return Marshal.ReadByte(source, i);
		}
	}

	public static NSData FromString(string s)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		return new NSString(s).Encode(NSStringEncoding.UTF8);
	}

	public unsafe static NSData FromArray(byte[] buffer)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (buffer.Length == 0)
		{
			return FromBytes(IntPtr.Zero, 0uL);
		}
		fixed (byte* ptr = &buffer[0])
		{
			return FromBytes((IntPtr)ptr, (uint)buffer.Length);
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
		NSMutableData nSMutableData = null;
		long capacity;
		try
		{
			capacity = stream.Length;
		}
		catch
		{
			capacity = 8192L;
		}
		nSMutableData = NSMutableData.FromCapacity((ulong)capacity);
		byte[] array = new byte[32768];
		try
		{
			int num;
			while ((num = stream.Read(array, 0, array.Length)) != 0)
			{
				try
				{
					fixed (byte* ptr = &array[0])
					{
						nSMutableData.AppendBytes((IntPtr)ptr, (uint)num);
					}
				}
				finally
				{
				}
			}
			return nSMutableData;
		}
		catch
		{
			return null;
		}
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
		return new NSString(s).Encode(encoding);
	}

	public static implicit operator NSData(string s)
	{
		return new NSString(s).Encode(NSStringEncoding.UTF8);
	}

	public NSString ToString(NSStringEncoding encoding)
	{
		return NSString.FromData(this, encoding);
	}

	public override string ToString()
	{
		return ToString(NSStringEncoding.UTF8);
	}

	public unsafe bool Save(string file, bool auxiliaryFile, out NSError error)
	{
		IntPtr ptr = default(IntPtr);
		IntPtr addr = (IntPtr)(&ptr);
		bool result = _Save(file, (ulong)(int)(auxiliaryFile ? 1u : 0u), addr);
		error = (NSError)Runtime.GetNSObject(ptr);
		return result;
	}

	public unsafe bool Save(string file, NSDataWritingOptions options, out NSError error)
	{
		IntPtr ptr = default(IntPtr);
		IntPtr addr = (IntPtr)(&ptr);
		bool result = _Save(file, (ulong)options, addr);
		error = (NSError)Runtime.GetNSObject(ptr);
		return result;
	}

	public unsafe bool Save(NSUrl url, bool auxiliaryFile, out NSError error)
	{
		IntPtr ptr = default(IntPtr);
		IntPtr addr = (IntPtr)(&ptr);
		bool result = _Save(url, (ulong)(int)(auxiliaryFile ? 1u : 0u), addr);
		error = (NSError)Runtime.GetNSObject(ptr);
		return result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSData()
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
	public NSData(NSCoder coder)
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
	public NSData(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSData(IntPtr handle)
		: base(handle)
	{
	}

	[Export("dataWithContentsOfURL:")]
	public static NSData FromUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDataWithContentsOfURL_Handle, url.Handle));
	}

	[Export("dataWithContentsOfURL:options:error:")]
	public static NSData FromUrl(NSUrl url, NSDataReadingOptions mask, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSData result = (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr(class_ptr, selDataWithContentsOfURLOptionsError_Handle, url.Handle, (ulong)mask, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("dataWithContentsOfFile:")]
	public static NSData FromFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSData result = (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDataWithContentsOfFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("dataWithContentsOfFile:options:error:")]
	public static NSData FromFile(string path, NSDataReadingOptions mask, out NSError error)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(path);
		NSData result = (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr(class_ptr, selDataWithContentsOfFileOptionsError_Handle, arg, (ulong)mask, intPtr));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("dataWithData:")]
	public static NSData FromData(NSData source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDataWithData_Handle, source.Handle));
	}

	[Export("dataWithBytes:length:")]
	public static NSData FromBytes(IntPtr bytes, ulong size)
	{
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(class_ptr, selDataWithBytesLength_Handle, bytes, size));
	}

	[Export("writeToFile:options:error:")]
	public virtual bool _Save(string file, ulong options, IntPtr addr)
	{
		if (file == null)
		{
			throw new ArgumentNullException("file");
		}
		IntPtr arg = NSString.CreateNative(file);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_UInt64_IntPtr(base.SuperHandle, selWriteToFileOptionsError_Handle, arg, options, addr) : Messaging.bool_objc_msgSend_IntPtr_UInt64_IntPtr(base.Handle, selWriteToFileOptionsError_Handle, arg, options, addr));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("writeToURL:options:error:")]
	public virtual bool _Save(NSUrl url, ulong options, IntPtr addr)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_UInt64_IntPtr(base.Handle, selWriteToURLOptionsError_Handle, url.Handle, options, addr);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_UInt64_IntPtr(base.SuperHandle, selWriteToURLOptionsError_Handle, url.Handle, options, addr);
	}

	[Export("rangeOfData:options:range:")]
	public virtual NSRange Find(NSData dataToFind, NSDataSearchOptions searchOptions, NSRange searchRange)
	{
		if (dataToFind == null)
		{
			throw new ArgumentNullException("dataToFind");
		}
		if (IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_IntPtr_UInt64_NSRange(base.Handle, selRangeOfDataOptionsRange_Handle, dataToFind.Handle, (ulong)searchOptions, searchRange);
		}
		return Messaging.NSRange_objc_msgSendSuper_IntPtr_UInt64_NSRange(base.SuperHandle, selRangeOfDataOptionsRange_Handle, dataToFind.Handle, (ulong)searchOptions, searchRange);
	}
}
