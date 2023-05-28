using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace Security;

public class SecTrust : INativeObject, IDisposable
{
	internal delegate void TrustEvaluateHandler(IntPtr block, IntPtr trust, SecTrustResult trustResult);

	internal delegate void TrustEvaluateErrorHandler(IntPtr block, IntPtr trust, bool result, IntPtr error);

	private static readonly TrustEvaluateHandler evaluate = TrampolineEvaluate;

	private static readonly TrustEvaluateErrorHandler evaluate_error = TrampolineEvaluateError;

	private IntPtr handle;

	[iOS(7, 0)]
	[Mac(10, 9)]
	public bool NetworkFetchAllowed
	{
		get
		{
			bool allowFetch;
			SecStatusCode secStatusCode = SecTrustGetNetworkFetchAllowed(handle, out allowFetch);
			if (secStatusCode != 0)
			{
				throw new InvalidOperationException(secStatusCode.ToString());
			}
			return allowFetch;
		}
		set
		{
			SecStatusCode secStatusCode = SecTrustSetNetworkFetchAllowed(handle, value);
			if (secStatusCode != 0)
			{
				throw new InvalidOperationException(secStatusCode.ToString());
			}
		}
	}

	public int Count
	{
		get
		{
			if (handle == IntPtr.Zero)
			{
				return 0;
			}
			return (int)SecTrustGetCertificateCount(handle);
		}
	}

	public SecCertificate this[nint index]
	{
		get
		{
			if (handle == IntPtr.Zero)
			{
				throw new ObjectDisposedException("SecTrust");
			}
			if (index < 0 || index >= Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return new SecCertificate(SecTrustGetCertificateAtIndex(handle, index));
		}
	}

	public IntPtr Handle => handle;

	public SecTrust(SecCertificate certificate, SecPolicy policy)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		Initialize(certificate.Handle, policy);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(7, 0)]
	private static extern SecStatusCode SecTrustCopyPolicies(IntPtr trust, ref IntPtr policies);

	[iOS(7, 0)]
	public SecPolicy[] GetPolicies()
	{
		IntPtr policies = IntPtr.Zero;
		SecStatusCode secStatusCode = SecTrustCopyPolicies(handle, ref policies);
		if (secStatusCode != 0)
		{
			throw new InvalidOperationException(secStatusCode.ToString());
		}
		return NSArray.ArrayFromHandle<SecPolicy>(policies);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecTrustSetPolicies(IntPtr trust, IntPtr policies);

	private void SetPolicies(IntPtr policy)
	{
		SecStatusCode secStatusCode = SecTrustSetPolicies(handle, policy);
		if (secStatusCode != 0)
		{
			throw new InvalidOperationException(secStatusCode.ToString());
		}
	}

	public void SetPolicy(SecPolicy policy)
	{
		if (policy == null)
		{
			throw new ArgumentNullException("policy");
		}
		SetPolicies(policy.Handle);
	}

	public void SetPolicies(IEnumerable<SecPolicy> policies)
	{
		if (policies == null)
		{
			throw new ArgumentNullException("policies");
		}
		using NSArray nSArray = NSArray.FromNSObjects(policies.ToArray());
		SetPolicies(nSArray.Handle);
	}

	public void SetPolicies(NSArray policies)
	{
		if (policies == null)
		{
			throw new ArgumentNullException("policies");
		}
		SetPolicies(policies.Handle);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(7, 0)]
	[Mac(10, 9)]
	private static extern SecStatusCode SecTrustGetNetworkFetchAllowed(IntPtr trust, out bool allowFetch);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(7, 0)]
	[Mac(10, 9)]
	private static extern SecStatusCode SecTrustSetNetworkFetchAllowed(IntPtr trust, bool allowFetch);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(7, 0)]
	private static extern SecStatusCode SecTrustCopyCustomAnchorCertificates(IntPtr trust, out IntPtr anchors);

	[iOS(7, 0)]
	public SecCertificate[] GetCustomAnchorCertificates()
	{
		IntPtr anchors;
		SecStatusCode secStatusCode = SecTrustCopyCustomAnchorCertificates(handle, out anchors);
		if (secStatusCode != 0)
		{
			throw new InvalidOperationException(secStatusCode.ToString());
		}
		return NSArray.ArrayFromHandle<SecCertificate>(anchors);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(7, 0)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'Evaluate (DispatchQueue, SecTrustWithErrorCallback)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'Evaluate (DispatchQueue, SecTrustWithErrorCallback)' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'Evaluate (DispatchQueue, SecTrustWithErrorCallback)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'Evaluate (DispatchQueue, SecTrustWithErrorCallback)' instead.")]
	private static extern SecStatusCode SecTrustEvaluateAsync(IntPtr trust, IntPtr queue, ref BlockLiteral block);

	[MonoPInvokeCallback(typeof(TrustEvaluateHandler))]
	private static void TrampolineEvaluate(IntPtr block, IntPtr trust, SecTrustResult trustResult)
	{
		SecTrustCallback target = BlockLiteral.GetTarget<SecTrustCallback>(block);
		if (target != null)
		{
			SecTrust trust2 = ((trust == IntPtr.Zero) ? null : new SecTrust(trust));
			target(trust2, trustResult);
		}
	}

	[iOS(7, 0)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'Evaluate (DispatchQueue, SecTrustWithErrorCallback)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'Evaluate (DispatchQueue, SecTrustWithErrorCallback)' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'Evaluate (DispatchQueue, SecTrustWithErrorCallback)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'Evaluate (DispatchQueue, SecTrustWithErrorCallback)' instead.")]
	[BindingImpl(BindingImplOptions.Optimizable)]
	public SecStatusCode Evaluate(DispatchQueue queue, SecTrustCallback handler)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral block = default(BlockLiteral);
		try
		{
			block.SetupBlockUnsafe(evaluate, handler);
			return SecTrustEvaluateAsync(handle, queue.Handle, ref block);
		}
		finally
		{
			block.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern SecStatusCode SecTrustEvaluateAsyncWithError(IntPtr trust, IntPtr queue, ref BlockLiteral block);

	[MonoPInvokeCallback(typeof(TrustEvaluateErrorHandler))]
	private static void TrampolineEvaluateError(IntPtr block, IntPtr trust, bool result, IntPtr error)
	{
		SecTrustWithErrorCallback target = BlockLiteral.GetTarget<SecTrustWithErrorCallback>(block);
		if (target != null)
		{
			SecTrust trust2 = ((trust == IntPtr.Zero) ? null : new SecTrust(trust));
			NSError error2 = ((error == IntPtr.Zero) ? null : new NSError(error));
			target(trust2, result, error2);
		}
	}

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[BindingImpl(BindingImplOptions.Optimizable)]
	public SecStatusCode Evaluate(DispatchQueue queue, SecTrustWithErrorCallback handler)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral block = default(BlockLiteral);
		try
		{
			block.SetupBlockUnsafe(evaluate_error, handler);
			return SecTrustEvaluateAsyncWithError(handle, queue.Handle, ref block);
		}
		finally
		{
			block.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(7, 0)]
	private static extern SecStatusCode SecTrustGetTrustResult(IntPtr trust, out SecTrustResult result);

	[iOS(7, 0)]
	public SecTrustResult GetTrustResult()
	{
		SecTrustResult result;
		SecStatusCode secStatusCode = SecTrustGetTrustResult(handle, out result);
		if (secStatusCode != 0)
		{
			throw new InvalidOperationException(secStatusCode.ToString());
		}
		return result;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(5, 0)]
	[TV(12, 0)]
	[Mac(10, 14)]
	[iOS(12, 0)]
	private static extern bool SecTrustEvaluateWithError(IntPtr trust, out IntPtr error);

	[Watch(5, 0)]
	[TV(12, 0)]
	[Mac(10, 14)]
	[iOS(12, 0)]
	public bool Evaluate(out NSError error)
	{
		IntPtr error2;
		bool result = SecTrustEvaluateWithError(handle, out error2);
		error = ((error2 == IntPtr.Zero) ? null : new NSError(error2));
		return result;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(7, 0)]
	[Mac(10, 9)]
	private static extern IntPtr SecTrustCopyResult(IntPtr trust);

	[iOS(7, 0)]
	[Mac(10, 9)]
	public NSDictionary GetResult()
	{
		return new NSDictionary(SecTrustCopyResult(handle), alloced: true);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(7, 0)]
	[Mac(10, 9)]
	private static extern SecStatusCode SecTrustSetOCSPResponse(IntPtr trust, IntPtr responseData);

	[Mac(10, 9)]
	private void SetOCSPResponse(IntPtr ocsp)
	{
		SecStatusCode secStatusCode = SecTrustSetOCSPResponse(handle, ocsp);
		if (secStatusCode != 0)
		{
			throw new InvalidOperationException(secStatusCode.ToString());
		}
	}

	[iOS(7, 0)]
	public void SetOCSPResponse(NSData ocspResponse)
	{
		if (ocspResponse == null)
		{
			throw new ArgumentNullException("ocspResponse");
		}
		SetOCSPResponse(ocspResponse.Handle);
	}

	[iOS(7, 0)]
	public void SetOCSPResponse(IEnumerable<NSData> ocspResponses)
	{
		if (ocspResponses == null)
		{
			throw new ArgumentNullException("ocspResponses");
		}
		using NSArray nSArray = NSArray.FromNSObjects(ocspResponses.ToArray());
		SetOCSPResponse(nSArray.Handle);
	}

	[iOS(7, 0)]
	public void SetOCSPResponse(NSArray ocspResponses)
	{
		if (ocspResponses == null)
		{
			throw new ArgumentNullException("ocspResponses");
		}
		SetOCSPResponse(ocspResponses.Handle);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(12, 1, 1)]
	[Watch(5, 1, 1)]
	[TV(12, 1, 1)]
	[Mac(10, 14, 2)]
	private static extern SecStatusCode SecTrustSetSignedCertificateTimestamps(IntPtr trust, IntPtr sctArray);

	[iOS(12, 1, 1)]
	[Watch(5, 1, 1)]
	[TV(12, 1, 1)]
	[Mac(10, 14, 2)]
	public SecStatusCode SetSignedCertificateTimestamps(IEnumerable<NSData> sct)
	{
		if (sct == null)
		{
			return SecTrustSetSignedCertificateTimestamps(handle, IntPtr.Zero);
		}
		using NSArray nSArray = NSArray.FromNSObjects(sct.ToArray());
		return SecTrustSetSignedCertificateTimestamps(handle, nSArray.Handle);
	}

	[iOS(12, 1, 1)]
	[Watch(5, 1, 1)]
	[TV(12, 1, 1)]
	[Mac(10, 14, 2)]
	public SecStatusCode SetSignedCertificateTimestamps(NSArray<NSData> sct)
	{
		return SecTrustSetSignedCertificateTimestamps(handle, sct.GetHandle());
	}

	public SecTrust(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	[Preserve(Conditional = true)]
	internal SecTrust(IntPtr handle, bool owns)
	{
		if (handle == IntPtr.Zero)
		{
			throw new Exception("Invalid handle");
		}
		this.handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security", EntryPoint = "SecTrustGetTypeID")]
	public static extern nint GetTypeID();

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecTrustCreateWithCertificates(IntPtr certOrCertArray, IntPtr policies, out IntPtr sectrustref);

	public SecTrust(X509Certificate certificate, SecPolicy policy)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		using SecCertificate secCertificate = new SecCertificate(certificate);
		Initialize(secCertificate.Handle, policy);
	}

	public SecTrust(X509Certificate2 certificate, SecPolicy policy)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		using SecCertificate secCertificate = new SecCertificate(certificate);
		Initialize(secCertificate.Handle, policy);
	}

	public SecTrust(X509CertificateCollection certificates, SecPolicy policy)
	{
		if (certificates == null)
		{
			throw new ArgumentNullException("certificates");
		}
		SecCertificate[] array = new SecCertificate[certificates.Count];
		int num = 0;
		foreach (X509Certificate certificate in certificates)
		{
			array[num++] = new SecCertificate(certificate);
		}
		Initialize(array, policy);
	}

	public SecTrust(X509Certificate2Collection certificates, SecPolicy policy)
	{
		if (certificates == null)
		{
			throw new ArgumentNullException("certificates");
		}
		SecCertificate[] array = new SecCertificate[certificates.Count];
		int num = 0;
		X509Certificate2Enumerator enumerator = certificates.GetEnumerator();
		while (enumerator.MoveNext())
		{
			X509Certificate2 current = enumerator.Current;
			array[num++] = new SecCertificate(current);
		}
		Initialize(array, policy);
	}

	private void Initialize(SecCertificate[] array, SecPolicy policy)
	{
		using CFArray cFArray = CFArray.FromNativeObjects(array);
		Initialize(cFArray.Handle, policy);
	}

	private void Initialize(IntPtr certHandle, SecPolicy policy)
	{
		SecStatusCode secStatusCode = SecTrustCreateWithCertificates(certHandle, (policy == null) ? IntPtr.Zero : policy.Handle, out handle);
		if (secStatusCode != 0)
		{
			throw new ArgumentException(secStatusCode.ToString());
		}
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecTrustEvaluate(IntPtr trust, out SecTrustResult result);

	[Deprecated(PlatformName.iOS, 12, 1, PlatformArchitecture.None, "Use 'SecTrust.Evaluate (out NSError)' instead.")]
	[Deprecated(PlatformName.TvOS, 12, 1, PlatformArchitecture.None, "Use 'SecTrust.Evaluate (out NSError)' instead.")]
	[Deprecated(PlatformName.WatchOS, 5, 1, PlatformArchitecture.None, "Use 'SecTrust.Evaluate (out NSError)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, 1, PlatformArchitecture.None, "Use 'SecTrust.Evaluate (out NSError)' instead.")]
	public SecTrustResult Evaluate()
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecTrust");
		}
		SecTrustResult result;
		SecStatusCode secStatusCode = SecTrustEvaluate(handle, out result);
		if (secStatusCode != 0)
		{
			throw new InvalidOperationException(secStatusCode.ToString());
		}
		return result;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern nint SecTrustGetCertificateCount(IntPtr trust);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr SecTrustGetCertificateAtIndex(IntPtr trust, nint ix);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr SecTrustCopyPublicKey(IntPtr trust);

	public SecKey GetPublicKey()
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecTrust");
		}
		return new SecKey(SecTrustCopyPublicKey(handle), owns: true);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Mac(10, 9)]
	private static extern IntPtr SecTrustCopyExceptions(IntPtr trust);

	[Mac(10, 9)]
	public NSData GetExceptions()
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecTrust");
		}
		return new NSData(SecTrustCopyExceptions(handle), owns: false);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Mac(10, 9)]
	private static extern bool SecTrustSetExceptions(IntPtr trust, IntPtr exceptions);

	[Mac(10, 9)]
	public bool SetExceptions(NSData data)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecTrust");
		}
		IntPtr exceptions = data?.Handle ?? IntPtr.Zero;
		return SecTrustSetExceptions(handle, exceptions);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern double SecTrustGetVerifyTime(IntPtr trust);

	public double GetVerifyTime()
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecTrust");
		}
		return SecTrustGetVerifyTime(handle);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecTrustSetVerifyDate(IntPtr trust, IntPtr verifyDate);

	public SecStatusCode SetVerifyDate(DateTime date)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecTrust");
		}
		using NSDate nSDate = (NSDate)date;
		return SecTrustSetVerifyDate(handle, nSDate.Handle);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecTrustSetAnchorCertificates(IntPtr trust, IntPtr anchorCertificates);

	public SecStatusCode SetAnchorCertificates(X509CertificateCollection certificates)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecTrust");
		}
		if (certificates == null)
		{
			return SecTrustSetAnchorCertificates(handle, IntPtr.Zero);
		}
		SecCertificate[] array = new SecCertificate[certificates.Count];
		int num = 0;
		foreach (X509Certificate certificate in certificates)
		{
			array[num++] = new SecCertificate(certificate);
		}
		return SetAnchorCertificates(array);
	}

	public SecStatusCode SetAnchorCertificates(X509Certificate2Collection certificates)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecTrust");
		}
		if (certificates == null)
		{
			return SecTrustSetAnchorCertificates(handle, IntPtr.Zero);
		}
		SecCertificate[] array = new SecCertificate[certificates.Count];
		int num = 0;
		X509Certificate2Enumerator enumerator = certificates.GetEnumerator();
		while (enumerator.MoveNext())
		{
			X509Certificate2 current = enumerator.Current;
			array[num++] = new SecCertificate(current);
		}
		return SetAnchorCertificates(array);
	}

	public SecStatusCode SetAnchorCertificates(SecCertificate[] array)
	{
		if (array == null)
		{
			return SecTrustSetAnchorCertificates(handle, IntPtr.Zero);
		}
		using CFArray cFArray = CFArray.FromNativeObjects(array);
		return SecTrustSetAnchorCertificates(handle, cFArray.Handle);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecTrustSetAnchorCertificatesOnly(IntPtr trust, bool anchorCertificatesOnly);

	public SecStatusCode SetAnchorCertificatesOnly(bool anchorCertificatesOnly)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("SecTrust");
		}
		return SecTrustSetAnchorCertificatesOnly(handle, anchorCertificatesOnly);
	}

	~SecTrust()
	{
		Dispose(disposing: false);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}
