using System;
using System.Reflection;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public class CTRunDelegateOperations : IDisposable
{
	internal GCHandle handle;

	protected CTRunDelegateOperations()
	{
		handle = GCHandle.Alloc(this);
	}

	public virtual void Dispose()
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
		CTRunDelegateCallbacks cTRunDelegateCallbacks = new CTRunDelegateCallbacks
		{
			version = CTRunDelegateVersion.Version1,
			dealloc = Deallocate
		};
		BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Public;
		MethodInfo method;
		if ((method = GetType().GetMethod("GetAscent", bindingAttr)) != null && method.DeclaringType != typeof(CTRunDelegateOperations))
		{
			cTRunDelegateCallbacks.getAscent = GetAscent;
		}
		if ((method = GetType().GetMethod("GetDescent", bindingAttr)) != null && method.DeclaringType != typeof(CTRunDelegateOperations))
		{
			cTRunDelegateCallbacks.getDescent = GetDescent;
		}
		if ((method = GetType().GetMethod("GetWidth", bindingAttr)) != null && method.DeclaringType != typeof(CTRunDelegateOperations))
		{
			cTRunDelegateCallbacks.getWidth = GetWidth;
		}
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

	[MonoPInvokeCallback(typeof(CTRunDelegateGetAscentCallback))]
	private static float GetAscent(IntPtr refCon)
	{
		return GetOperations(refCon)?.GetAscent() ?? 0f;
	}

	[MonoPInvokeCallback(typeof(CTRunDelegateGetDescentCallback))]
	private static float GetDescent(IntPtr refCon)
	{
		return GetOperations(refCon)?.GetDescent() ?? 0f;
	}

	[MonoPInvokeCallback(typeof(CTRunDelegateGetWidthCallback))]
	private static float GetWidth(IntPtr refCon)
	{
		return GetOperations(refCon)?.GetWidth() ?? 0f;
	}
}
