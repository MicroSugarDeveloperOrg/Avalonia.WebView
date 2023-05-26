using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace Security;

public class SecKey : INativeObject, IDisposable
{
	internal IntPtr handle;

	private long BlockSize
	{
		get
		{
			if (handle == IntPtr.Zero)
			{
				throw new ObjectDisposedException("SecKey");
			}
			return (long)SecKeyGetBlockSize(handle);
		}
	}

	public IntPtr Handle => handle;

	public SecKey(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	[Preserve(Conditional = true)]
	public SecKey(IntPtr handle, bool owns)
	{
		this.handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security", EntryPoint = "SecKeyGetTypeID")]
	public static extern int GetTypeID();

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecKeyGeneratePair(IntPtr dictHandle, out IntPtr pubKey, out IntPtr privKey);

	public static SecStatusCode GenerateKeyPair(NSDictionary parameters, out SecKey publicKey, out SecKey privateKey)
	{
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		IntPtr pubKey;
		IntPtr privKey;
		SecStatusCode num = SecKeyGeneratePair(parameters.Handle, out pubKey, out privKey);
		if (num == SecStatusCode.Success)
		{
			publicKey = new SecKey(pubKey, owns: true);
			privateKey = new SecKey(privKey, owns: true);
			return num;
		}
		publicKey = (privateKey = null);
		return num;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr SecKeyGetBlockSize(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecKeyRawSign(IntPtr handle, SecPadding padding, IntPtr dataToSign, IntPtr dataToSignLen, IntPtr sig, IntPtr sigLen);

	private unsafe SecStatusCode RawSign(SecPadding padding, IntPtr dataToSign, int dataToSignLen, out byte[] result)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecKey");
		}
		result = new byte[(int)SecKeyGetBlockSize(handle)];
		fixed (byte* ptr = &result[0])
		{
			return SecKeyRawSign(handle, padding, dataToSign, (IntPtr)dataToSignLen, (IntPtr)ptr, (IntPtr)result.Length);
		}
	}

	private unsafe SecStatusCode RawSign(SecPadding padding, byte[] dataToSign, out byte[] result)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecKey");
		}
		if (dataToSign == null)
		{
			throw new ArgumentNullException("dataToSign");
		}
		result = new byte[(int)SecKeyGetBlockSize(handle)];
		fixed (byte* ptr = &dataToSign[0])
		{
			fixed (byte* ptr2 = &result[0])
			{
				return SecKeyRawSign(handle, padding, (IntPtr)ptr, (IntPtr)dataToSign.Length, (IntPtr)ptr2, (IntPtr)result.Length);
			}
		}
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecKeyRawVerify(IntPtr handle, SecPadding padding, IntPtr signedData, IntPtr signedLen, IntPtr sign, IntPtr signLen);

	public SecStatusCode RawVerify(SecPadding padding, IntPtr signedData, int signedDataLen, IntPtr signature, int signatureLen)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecKey");
		}
		return SecKeyRawVerify(handle, padding, signedData, (IntPtr)signedDataLen, signature, (IntPtr)signatureLen);
	}

	public unsafe SecStatusCode RawVerify(SecPadding padding, byte[] signedData, byte[] signature)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecKey");
		}
		if (signature == null)
		{
			throw new ArgumentNullException("signature");
		}
		if (signedData == null)
		{
			throw new ArgumentNullException("signedData");
		}
		fixed (byte* ptr2 = &signature[0])
		{
			fixed (byte* ptr = &signedData[0])
			{
				return SecKeyRawVerify(handle, padding, (IntPtr)ptr, (IntPtr)signedData.Length, (IntPtr)ptr2, (IntPtr)signature.Length);
			}
		}
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecKeyEncrypt(IntPtr handle, SecPadding padding, IntPtr plainText, IntPtr playLen, IntPtr cipherText, IntPtr cipherLen);

	public SecStatusCode Encrypt(SecPadding padding, IntPtr plainText, int playLen, IntPtr cipherText, int cipherLen)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecKey");
		}
		return SecKeyEncrypt(handle, padding, plainText, (IntPtr)playLen, cipherText, (IntPtr)cipherLen);
	}

	public unsafe SecStatusCode Encrypt(SecPadding padding, byte[] plainText, byte[] cipherText)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecKey");
		}
		if (cipherText == null)
		{
			throw new ArgumentNullException("cipherText");
		}
		if (plainText == null)
		{
			throw new ArgumentNullException("plainText");
		}
		fixed (byte* ptr2 = &cipherText[0])
		{
			fixed (byte* ptr = &plainText[0])
			{
				return SecKeyEncrypt(handle, padding, (IntPtr)ptr, (IntPtr)plainText.Length, (IntPtr)ptr2, (IntPtr)cipherText.Length);
			}
		}
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecKeyDecrypt(IntPtr handle, SecPadding padding, IntPtr cipherText, IntPtr cipherLen, IntPtr plainText, IntPtr playLen);

	public SecStatusCode Decrypt(SecPadding padding, IntPtr cipherText, int cipherLen, IntPtr plainText, int playLen)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecKey");
		}
		return SecKeyDecrypt(handle, padding, cipherText, (IntPtr)cipherLen, plainText, (IntPtr)playLen);
	}

	public unsafe SecStatusCode Decrypt(SecPadding padding, byte[] cipherText, byte[] plainText)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecKey");
		}
		if (cipherText == null)
		{
			throw new ArgumentNullException("cipherText");
		}
		if (plainText == null)
		{
			throw new ArgumentNullException("plainText");
		}
		fixed (byte* ptr = &cipherText[0])
		{
			fixed (byte* ptr2 = &plainText[0])
			{
				return SecKeyDecrypt(handle, padding, (IntPtr)ptr, (IntPtr)cipherText.Length, (IntPtr)ptr2, (IntPtr)plainText.Length);
			}
		}
	}

	~SecKey()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	public virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}
}
