using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreText;

public class CTRunDelegateOperations : IDisposable
{
	internal GCHandle handle;

	protected CTRunDelegateOperations()
	{
		handle = GCHandle.Alloc(this);
	}

	~CTRunDelegateOperations()
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
	}

	public virtual float GetAscent()
	{
		return 0f;
	}

	public virtual float GetDescent()
	{
		return 0f;
	}

	public virtual float GetWidth()
	{
		return 0f;
	}

	internal CTRunDelegateCallbacks GetCallbacks()
	{
		CTRunDelegateCallbacks cTRunDelegateCallbacks = new CTRunDelegateCallbacks();
		cTRunDelegateCallbacks.version = 1;
		cTRunDelegateCallbacks.dealloc = Deallocate;
		cTRunDelegateCallbacks.getAscent = GetAscent;
		cTRunDelegateCallbacks.getDescent = GetDescent;
		cTRunDelegateCallbacks.getWidth = GetWidth;
		return cTRunDelegateCallbacks;
	}

	[MonoPInvokeCallback(typeof(CTRunDelegateDeallocateCallback))]
	private static void Deallocate(IntPtr refCon)
	{
		CTRunDelegateOperations operations = GetOperations(refCon);
		if (operations != null)
		{
			operations.Dispose();
			if (operations.handle.IsAllocated)
			{
				operations.handle.Free();
			}
			operations.handle = default(GCHandle);
		}
	}

	internal static CTRunDelegateOperations GetOperations(IntPtr refCon)
	{
		return GCHandle.FromIntPtr(refCon).Target as CTRunDelegateOperations;
	}

	[MonoPInvokeCallback(typeof(CTRunDelegateGetCallback))]
	private static nfloat GetAscent(IntPtr refCon)
	{
		CTRunDelegateOperations operations = GetOperations(refCon);
		if (operations == null)
		{
			return 0;
		}
		return operations.GetAscent();
	}

	[MonoPInvokeCallback(typeof(CTRunDelegateGetCallback))]
	private static nfloat GetDescent(IntPtr refCon)
	{
		CTRunDelegateOperations operations = GetOperations(refCon);
		if (operations == null)
		{
			return 0;
		}
		return operations.GetDescent();
	}

	[MonoPInvokeCallback(typeof(CTRunDelegateGetCallback))]
	private static nfloat GetWidth(IntPtr refCon)
	{
		CTRunDelegateOperations operations = GetOperations(refCon);
		if (operations == null)
		{
			return 0;
		}
		return operations.GetWidth();
	}
}
