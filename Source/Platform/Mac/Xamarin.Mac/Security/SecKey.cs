using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace Security;

public class SecKey : INativeObject, IDisposable
{
	internal IntPtr handle;

	public int BlockSize
	{
		get
		{
			if (handle == IntPtr.Zero)
			{
				throw new ObjectDisposedException("SecKey");
			}
			return (int)SecKeyGetBlockSize(handle);
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
	public static extern nint GetTypeID();

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
		SecStatusCode secStatusCode = SecKeyGeneratePair(parameters.Handle, out pubKey, out privKey);
		if (secStatusCode == SecStatusCode.Success)
		{
			publicKey = new SecKey(pubKey, owns: true);
			privateKey = new SecKey(privKey, owns: true);
		}
		else
		{
			publicKey = (privateKey = null);
		}
		return secStatusCode;
	}

	[Advice("On iOS this method applies the attributes to both public and private key. To apply different attributes to each key, use 'GenerateKeyPair (SecKeyType, int, SecPublicPrivateKeyAttrs, SecPublicPrivateKeyAttrs, out SecKey, out SecKey)' instead.")]
	public static SecStatusCode GenerateKeyPair(SecKeyType type, int keySizeInBits, SecPublicPrivateKeyAttrs publicAndPrivateKeyAttrs, out SecKey publicKey, out SecKey privateKey)
	{
		if (type == SecKeyType.Invalid)
		{
			throw new ArgumentException("invalid 'SecKeyType'", "type");
		}
		NSMutableDictionary nSMutableDictionary = ((publicAndPrivateKeyAttrs == null) ? new NSMutableDictionary() : new NSMutableDictionary(publicAndPrivateKeyAttrs.GetDictionary()));
		nSMutableDictionary.LowlevelSetObject(type.GetConstant(), SecAttributeKey.Type);
		nSMutableDictionary.LowlevelSetObject(new NSNumber(keySizeInBits), SecKeyGenerationAttributeKeys.KeySizeInBitsKey.Handle);
		return GenerateKeyPair(nSMutableDictionary, out publicKey, out privateKey);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern nint SecKeyGetBlockSize(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecKeyRawSign(IntPtr handle, SecPadding padding, IntPtr dataToSign, nint dataToSignLen, IntPtr sig, ref nint sigLen);

	public SecStatusCode RawSign(SecPadding padding, IntPtr dataToSign, int dataToSignLen, out byte[] result)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecKey");
		}
		if (dataToSign == IntPtr.Zero)
		{
			throw new ArgumentException("dataToSign");
		}
		return _RawSign(padding, dataToSign, dataToSignLen, out result);
	}

	public unsafe SecStatusCode RawSign(SecPadding padding, byte[] dataToSign, out byte[] result)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecKey");
		}
		if (dataToSign == null)
		{
			throw new ArgumentNullException("dataToSign");
		}
		fixed (byte* ptr = dataToSign)
		{
			return _RawSign(padding, (IntPtr)ptr, dataToSign.Length, out result);
		}
	}

	private unsafe SecStatusCode _RawSign(SecPadding padding, IntPtr dataToSign, int dataToSignLen, out byte[] result)
	{
		nint sigLen = 1024;
		result = new byte[(long)sigLen];
		SecStatusCode result2;
		fixed (byte* ptr = result)
		{
			result2 = SecKeyRawSign(handle, padding, dataToSign, dataToSignLen, (IntPtr)ptr, ref sigLen);
			Array.Resize(ref result, (int)sigLen);
		}
		return result2;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecKeyRawVerify(IntPtr handle, SecPadding padding, IntPtr signedData, nint signedLen, IntPtr sign, nint signLen);

	public SecStatusCode RawVerify(SecPadding padding, IntPtr signedData, int signedDataLen, IntPtr signature, int signatureLen)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecKey");
		}
		return SecKeyRawVerify(handle, padding, signedData, signedDataLen, signature, signatureLen);
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
		byte[] array = ((signature.Length == 0) ? new byte[1] : signature);
		byte[] array2 = ((signedData.Length == 0) ? new byte[1] : signedData);
		fixed (byte* ptr2 = array)
		{
			fixed (byte* ptr = array2)
			{
				return SecKeyRawVerify(handle, padding, (IntPtr)ptr, signedData.Length, (IntPtr)ptr2, signature.Length);
			}
		}
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecKeyEncrypt(IntPtr handle, SecPadding padding, IntPtr plainText, nint plainTextLen, IntPtr cipherText, ref nint cipherTextLengh);

	public SecStatusCode Encrypt(SecPadding padding, IntPtr plainText, nint plainTextLen, IntPtr cipherText, ref nint cipherTextLen)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecKey");
		}
		return SecKeyEncrypt(handle, padding, plainText, plainTextLen, cipherText, ref cipherTextLen);
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
		fixed (byte* ptr2 = cipherText)
		{
			fixed (byte* ptr = plainText)
			{
				nint cipherTextLengh = cipherText.Length;
				return SecKeyEncrypt(handle, padding, (IntPtr)ptr, plainText.Length, (IntPtr)ptr2, ref cipherTextLengh);
			}
		}
	}

	public SecStatusCode Encrypt(SecPadding padding, byte[] plainText, out byte[] cipherText)
	{
		cipherText = new byte[BlockSize];
		return Encrypt(padding, plainText, cipherText);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecKeyDecrypt(IntPtr handle, SecPadding padding, IntPtr cipherTextLen, nint cipherLen, IntPtr plainText, ref nint plainTextLen);

	public SecStatusCode Decrypt(SecPadding padding, IntPtr cipherText, nint cipherTextLen, IntPtr plainText, ref nint plainTextLen)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecKey");
		}
		return SecKeyDecrypt(handle, padding, cipherText, cipherTextLen, plainText, ref plainTextLen);
	}

	private unsafe SecStatusCode _Decrypt(SecPadding padding, byte[] cipherText, ref byte[] plainText)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecKey");
		}
		if (cipherText == null)
		{
			throw new ArgumentNullException("cipherText");
		}
		fixed (byte* ptr = cipherText)
		{
			if (plainText == null)
			{
				plainText = new byte[cipherText.Length];
			}
			nint plainTextLen = plainText.Length;
			SecStatusCode result;
			fixed (byte* ptr2 = plainText)
			{
				result = SecKeyDecrypt(handle, padding, (IntPtr)ptr, cipherText.Length, (IntPtr)ptr2, ref plainTextLen);
			}
			if (plainTextLen < plainText.Length)
			{
				Array.Resize(ref plainText, (int)plainTextLen);
			}
			return result;
		}
	}

	public SecStatusCode Decrypt(SecPadding padding, byte[] cipherText, out byte[] plainText)
	{
		plainText = null;
		return _Decrypt(padding, cipherText, ref plainText);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	private static extern IntPtr SecKeyCreateRandomKey(IntPtr parameters, out IntPtr error);

	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	public static SecKey CreateRandomKey(NSDictionary parameters, out NSError error)
	{
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		IntPtr error2;
		IntPtr intPtr = SecKeyCreateRandomKey(parameters.Handle, out error2);
		error = ((error2 == IntPtr.Zero) ? null : new NSError(error2));
		return (intPtr == IntPtr.Zero) ? null : new SecKey(intPtr, owns: true);
	}

	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	public static SecKey CreateRandomKey(SecKeyType keyType, int keySizeInBits, NSDictionary parameters, out NSError error)
	{
		using NSNumber obj = new NSNumber(keySizeInBits);
		using NSMutableDictionary nSMutableDictionary = ((parameters == null) ? new NSMutableDictionary() : new NSMutableDictionary(parameters));
		nSMutableDictionary.LowlevelSetObject(keyType.GetConstant(), SecKeyGenerationAttributeKeys.KeyTypeKey.Handle);
		nSMutableDictionary.LowlevelSetObject(obj, SecKeyGenerationAttributeKeys.KeySizeInBitsKey.Handle);
		return CreateRandomKey(nSMutableDictionary, out error);
	}

	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	public static SecKey CreateRandomKey(SecKeyGenerationParameters parameters, out NSError error)
	{
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		if (parameters.KeyType == SecKeyType.Invalid)
		{
			throw new ArgumentException("invalid 'SecKeyType'", "SecKeyGeneration.KeyType");
		}
		using NSDictionary parameters2 = parameters.GetDictionary();
		return CreateRandomKey(parameters2, out error);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	private static extern IntPtr SecKeyCreateWithData(IntPtr keyData, IntPtr attributes, out IntPtr error);

	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	public static SecKey Create(NSData keyData, NSDictionary parameters, out NSError error)
	{
		if (keyData == null)
		{
			throw new ArgumentNullException("keyData");
		}
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		IntPtr error2;
		IntPtr intPtr = SecKeyCreateWithData(keyData.Handle, parameters.Handle, out error2);
		error = ((error2 == IntPtr.Zero) ? null : new NSError(error2));
		return (intPtr == IntPtr.Zero) ? null : new SecKey(intPtr, owns: true);
	}

	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	public static SecKey Create(NSData keyData, SecKeyType keyType, SecKeyClass keyClass, int keySizeInBits, NSDictionary parameters, out NSError error)
	{
		using NSNumber obj = new NSNumber(keySizeInBits);
		using NSMutableDictionary nSMutableDictionary = ((parameters == null) ? new NSMutableDictionary() : new NSMutableDictionary(parameters));
		nSMutableDictionary.LowlevelSetObject(keyType.GetConstant(), SecKeyGenerationAttributeKeys.KeyTypeKey.Handle);
		nSMutableDictionary.LowlevelSetObject(keyClass.GetConstant(), SecAttributeKey.KeyClass);
		nSMutableDictionary.LowlevelSetObject(obj, SecKeyGenerationAttributeKeys.KeySizeInBitsKey.Handle);
		return Create(keyData, nSMutableDictionary, out error);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	private static extern IntPtr SecKeyCopyExternalRepresentation(IntPtr key, out IntPtr error);

	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	public NSData GetExternalRepresentation(out NSError error)
	{
		IntPtr error2;
		IntPtr ptr = SecKeyCopyExternalRepresentation(handle, out error2);
		error = ((error2 == IntPtr.Zero) ? null : new NSError(error2));
		return Runtime.GetNSObject<NSData>(ptr, owns: true);
	}

	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	public NSData GetExternalRepresentation()
	{
		IntPtr error;
		IntPtr ptr = SecKeyCopyExternalRepresentation(handle, out error);
		return Runtime.GetNSObject<NSData>(ptr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	private static extern IntPtr SecKeyCopyAttributes(IntPtr key);

	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	public NSDictionary GetAttributes()
	{
		IntPtr ptr = SecKeyCopyAttributes(handle);
		return Runtime.GetNSObject<NSDictionary>(ptr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	private static extern IntPtr SecKeyCopyPublicKey(IntPtr key);

	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	public SecKey GetPublicKey()
	{
		IntPtr intPtr = SecKeyCopyPublicKey(handle);
		return (intPtr == IntPtr.Zero) ? null : new SecKey(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	private static extern bool SecKeyIsAlgorithmSupported(IntPtr key, nint operation, IntPtr algorithm);

	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	public bool IsAlgorithmSupported(SecKeyOperationType operation, SecKeyAlgorithm algorithm)
	{
		return SecKeyIsAlgorithmSupported(handle, (int)operation, algorithm.GetConstant().Handle);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	private static extern IntPtr SecKeyCreateSignature(IntPtr key, IntPtr algorithm, IntPtr dataToSign, out IntPtr error);

	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	public NSData CreateSignature(SecKeyAlgorithm algorithm, NSData dataToSign, out NSError error)
	{
		if (dataToSign == null)
		{
			throw new ArgumentNullException("dataToSign");
		}
		IntPtr error2;
		IntPtr ptr = SecKeyCreateSignature(Handle, algorithm.GetConstant().Handle, dataToSign.Handle, out error2);
		error = ((error2 == IntPtr.Zero) ? null : new NSError(error2));
		return Runtime.GetNSObject<NSData>(ptr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	private static extern bool SecKeyVerifySignature(IntPtr key, IntPtr algorithm, IntPtr signedData, IntPtr signature, out IntPtr error);

	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	public bool VerifySignature(SecKeyAlgorithm algorithm, NSData signedData, NSData signature, out NSError error)
	{
		if (signedData == null)
		{
			throw new ArgumentNullException("signedData");
		}
		if (signature == null)
		{
			throw new ArgumentNullException("signature");
		}
		IntPtr error2;
		bool result = SecKeyVerifySignature(Handle, algorithm.GetConstant().Handle, signedData.Handle, signature.Handle, out error2);
		error = ((error2 == IntPtr.Zero) ? null : new NSError(error2));
		return result;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	private static extern IntPtr SecKeyCreateEncryptedData(IntPtr key, IntPtr algorithm, IntPtr plaintext, out IntPtr error);

	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	public NSData CreateEncryptedData(SecKeyAlgorithm algorithm, NSData plaintext, out NSError error)
	{
		if (plaintext == null)
		{
			throw new ArgumentNullException("plaintext");
		}
		IntPtr error2;
		IntPtr ptr = SecKeyCreateEncryptedData(Handle, algorithm.GetConstant().Handle, plaintext.Handle, out error2);
		error = ((error2 == IntPtr.Zero) ? null : new NSError(error2));
		return Runtime.GetNSObject<NSData>(ptr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	private static extern IntPtr SecKeyCreateDecryptedData(IntPtr key, IntPtr algorithm, IntPtr ciphertext, out IntPtr error);

	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	public NSData CreateDecryptedData(SecKeyAlgorithm algorithm, NSData ciphertext, out NSError error)
	{
		if (ciphertext == null)
		{
			throw new ArgumentNullException("ciphertext");
		}
		IntPtr error2;
		IntPtr ptr = SecKeyCreateDecryptedData(Handle, algorithm.GetConstant().Handle, ciphertext.Handle, out error2);
		error = ((error2 == IntPtr.Zero) ? null : new NSError(error2));
		return Runtime.GetNSObject<NSData>(ptr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	private static extern IntPtr SecKeyCopyKeyExchangeResult(IntPtr privateKey, IntPtr algorithm, IntPtr publicKey, IntPtr parameters, out IntPtr error);

	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	public NSData GetKeyExchangeResult(SecKeyAlgorithm algorithm, SecKey publicKey, NSDictionary parameters, out NSError error)
	{
		if (publicKey == null)
		{
			throw new ArgumentNullException("publicKey");
		}
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		IntPtr error2;
		IntPtr ptr = SecKeyCopyKeyExchangeResult(Handle, algorithm.GetConstant().Handle, publicKey.Handle, parameters.Handle, out error2);
		error = ((error2 == IntPtr.Zero) ? null : new NSError(error2));
		return Runtime.GetNSObject<NSData>(ptr, owns: true);
	}

	[Watch(3, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	[iOS(10, 0)]
	public NSData GetKeyExchangeResult(SecKeyAlgorithm algorithm, SecKey publicKey, SecKeyKeyExchangeParameter parameters, out NSError error)
	{
		return GetKeyExchangeResult(algorithm, publicKey, parameters?.Dictionary, out error);
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

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}
}
