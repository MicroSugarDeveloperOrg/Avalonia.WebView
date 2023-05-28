using System.Collections.Generic;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreFoundation;

public class CFMessagePort : INativeObject, IDisposable
{
	private struct ContextProxy
	{
		private nint version;

		public IntPtr info;

		public Func<IntPtr, IntPtr> retain;

		public Action<IntPtr> release;

		public Func<IntPtr, IntPtr> copyDescription;
	}

	public delegate NSData CFMessagePortCallBack(int type, NSData data);

	private delegate IntPtr CFMessagePortCallBackProxy(IntPtr messagePort, int type, IntPtr data, IntPtr info);

	private delegate void CFMessagePortInvalidationCallBackProxy(IntPtr messagePort, IntPtr info);

	private static Dictionary<IntPtr, CFMessagePortCallBack> outputHandles = new Dictionary<IntPtr, CFMessagePortCallBack>(Runtime.IntPtrEqualityComparer);

	private static Dictionary<IntPtr, Action> invalidationHandles = new Dictionary<IntPtr, Action>(Runtime.IntPtrEqualityComparer);

	private static Dictionary<IntPtr, CFMessagePortContext> messagePortContexts = new Dictionary<IntPtr, CFMessagePortContext>(Runtime.IntPtrEqualityComparer);

	private static CFMessagePortCallBackProxy messageOutputCallback = MessagePortCallback;

	private static CFMessagePortInvalidationCallBackProxy messageInvalidationCallback = MessagePortInvalidationCallback;

	private GCHandle gch;

	private IntPtr handle;

	private IntPtr contextHandle = IntPtr.Zero;

	public IntPtr Handle => handle;

	public bool IsRemote
	{
		get
		{
			Check();
			return CFMessagePortIsRemote(handle);
		}
	}

	public string Name
	{
		get
		{
			Check();
			return NSString.FromHandle(CFMessagePortGetName(handle));
		}
		set
		{
			Check();
			IntPtr newName = NSString.CreateNative(value);
			CFMessagePortSetName(handle, newName);
			NSString.ReleaseNative(newName);
		}
	}

	public bool IsValid
	{
		get
		{
			Check();
			return CFMessagePortIsValid(handle);
		}
	}

	internal CFMessagePortContext Context
	{
		get
		{
			Check();
			ContextProxy context = default(ContextProxy);
			CFMessagePortGetContext(handle, ref context);
			if (context.info == IntPtr.Zero)
			{
				return null;
			}
			CFMessagePortContext value;
			lock (messagePortContexts)
			{
				messagePortContexts.TryGetValue(context.info, out value);
			}
			return value;
		}
	}

	public Action InvalidationCallback
	{
		get
		{
			Check();
			Action value;
			lock (invalidationHandles)
			{
				invalidationHandles.TryGetValue(handle, out value);
			}
			return value;
		}
		set
		{
			Check();
			lock (invalidationHandles)
			{
				if (value == null)
				{
					invalidationHandles[handle] = null;
				}
				else
				{
					invalidationHandles.Add(handle, value);
				}
			}
			CFMessagePortSetInvalidationCallBack(handle, messageInvalidationCallback);
		}
	}

	internal CFMessagePort(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	[Preserve(Conditional = true)]
	internal CFMessagePort(IntPtr handle, bool owns)
	{
		this.handle = handle;
		gch = GCHandle.Alloc(this);
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
	}

	~CFMessagePort()
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
		if (disposing && gch.IsAllocated)
		{
			gch.Free();
		}
		if (!(handle != IntPtr.Zero))
		{
			return;
		}
		lock (outputHandles)
		{
			outputHandles.Remove(handle);
		}
		lock (invalidationHandles)
		{
			if (invalidationHandles.ContainsKey(handle))
			{
				invalidationHandles.Remove(handle);
			}
		}
		lock (messagePortContexts)
		{
			if (messagePortContexts.ContainsKey(contextHandle))
			{
				invalidationHandles.Remove(contextHandle);
			}
		}
		CFObject.CFRelease(handle);
		contextHandle = IntPtr.Zero;
		handle = IntPtr.Zero;
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFMessagePortCreateLocal(IntPtr allocator, IntPtr name, CFMessagePortCallBackProxy callout, ref ContextProxy context, [MarshalAs(UnmanagedType.I1)] ref bool shouldFreeInfo);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFMessagePortCreateRemote(IntPtr allocator, IntPtr name);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFMessagePortInvalidate(IntPtr ms);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFMessagePortCreateRunLoopSource(IntPtr allocator, IntPtr local, nint order);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern CFMessagePortSendRequestStatus CFMessagePortSendRequest(IntPtr remote, int msgid, IntPtr data, double sendTimeout, double rcvTimeout, IntPtr replyMode, ref IntPtr returnData);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool CFMessagePortIsRemote(IntPtr ms);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool CFMessagePortSetName(IntPtr ms, IntPtr newName);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFMessagePortGetName(IntPtr ms);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFMessagePortGetContext(IntPtr ms, ref ContextProxy context);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool CFMessagePortIsValid(IntPtr ms);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFMessagePortSetDispatchQueue(IntPtr ms, IntPtr queue);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFMessagePortSetInvalidationCallBack(IntPtr ms, CFMessagePortInvalidationCallBackProxy callout);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFMessagePortGetInvalidationCallBack(IntPtr ms);

	public static CFMessagePort CreateLocalPort(string name, CFMessagePortCallBack callback, CFAllocator allocator = null)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		return CreateLocalPort(allocator, name, callback, null);
	}

	internal static CFMessagePort CreateLocalPort(CFAllocator allocator, string name, CFMessagePortCallBack callback, CFMessagePortContext context)
	{
		IntPtr allocator2 = allocator?.Handle ?? IntPtr.Zero;
		IntPtr name2 = NSString.CreateNative(name);
		bool shouldFreeInfo = false;
		ContextProxy context2 = default(ContextProxy);
		GCHandle gCHandle = GCHandle.Alloc(context2);
		if (context != null)
		{
			if (context.Retain != null)
			{
				context2.retain = RetainProxy;
			}
			if (context.Release != null)
			{
				context2.release = ReleaseProxy;
			}
			if (context.CopyDescription != null)
			{
				context2.copyDescription = CopyDescriptionProxy;
			}
			context2.info = (IntPtr)gCHandle;
			lock (messagePortContexts)
			{
				messagePortContexts.Add(context2.info, context);
			}
		}
		try
		{
			IntPtr intPtr = CFMessagePortCreateLocal(allocator2, name2, messageOutputCallback, ref context2, ref shouldFreeInfo);
			gCHandle.Free();
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			CFMessagePort cFMessagePort = new CFMessagePort(intPtr);
			lock (outputHandles)
			{
				outputHandles.Add(intPtr, callback);
			}
			if (context != null)
			{
				lock (messagePortContexts)
				{
					messagePortContexts.Remove(context2.info);
					CFMessagePortGetContext(intPtr, ref context2);
					messagePortContexts.Add(context2.info, context);
				}
				cFMessagePort.contextHandle = context2.info;
			}
			return cFMessagePort;
		}
		finally
		{
			NSString.ReleaseNative(name2);
		}
	}

	[MonoPInvokeCallback(typeof(Func<IntPtr, IntPtr>))]
	private static IntPtr RetainProxy(IntPtr info)
	{
		INativeObject nativeObject = null;
		CFMessagePortContext value;
		lock (messagePortContexts)
		{
			messagePortContexts.TryGetValue(info, out value);
		}
		if (value != null && value.Retain != null)
		{
			nativeObject = value.Retain();
		}
		return nativeObject?.Handle ?? IntPtr.Zero;
	}

	[MonoPInvokeCallback(typeof(Action<IntPtr>))]
	private static void ReleaseProxy(IntPtr info)
	{
		CFMessagePortContext value;
		lock (messagePortContexts)
		{
			messagePortContexts.TryGetValue(info, out value);
		}
		if (value != null && value.Release != null)
		{
			value.Release();
		}
	}

	[MonoPInvokeCallback(typeof(Func<IntPtr, IntPtr>))]
	private static IntPtr CopyDescriptionProxy(IntPtr info)
	{
		NSString nSString = null;
		CFMessagePortContext value;
		lock (messagePortContexts)
		{
			messagePortContexts.TryGetValue(info, out value);
		}
		if (value != null && value.CopyDescription != null)
		{
			nSString = value.CopyDescription();
		}
		return (nSString == null) ? IntPtr.Zero : nSString.Handle;
	}

	[MonoPInvokeCallback(typeof(CFMessagePortCallBackProxy))]
	private static IntPtr MessagePortCallback(IntPtr local, int msgid, IntPtr data, IntPtr info)
	{
		CFMessagePortCallBack cFMessagePortCallBack;
		lock (outputHandles)
		{
			cFMessagePortCallBack = outputHandles[local];
		}
		if (cFMessagePortCallBack == null)
		{
			return IntPtr.Zero;
		}
		using NSData data2 = Runtime.GetNSObject<NSData>(data);
		NSData nSData = cFMessagePortCallBack(msgid, data2);
		nSData?.DangerousRetain();
		return nSData?.Handle ?? IntPtr.Zero;
	}

	[MonoPInvokeCallback(typeof(CFMessagePortInvalidationCallBackProxy))]
	private static void MessagePortInvalidationCallback(IntPtr messagePort, IntPtr info)
	{
		Action value;
		lock (invalidationHandles)
		{
			invalidationHandles.TryGetValue(messagePort, out value);
		}
		value?.Invoke();
	}

	public static CFMessagePort CreateRemotePort(CFAllocator allocator, string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr allocator2 = allocator?.Handle ?? IntPtr.Zero;
		IntPtr name2 = NSString.CreateNative(name);
		try
		{
			IntPtr intPtr = CFMessagePortCreateRemote(allocator2, name2);
			return (intPtr == IntPtr.Zero) ? null : new CFMessagePort(intPtr);
		}
		finally
		{
			NSString.ReleaseNative(name2);
		}
	}

	public void Invalidate()
	{
		Check();
		CFMessagePortInvalidate(handle);
	}

	public CFMessagePortSendRequestStatus SendRequest(int msgid, NSData data, double sendTimeout, double rcvTimeout, NSString replyMode, out NSData returnData)
	{
		Check();
		IntPtr replyMode2 = ((replyMode == null) ? IntPtr.Zero : replyMode.Handle);
		IntPtr returnData2 = IntPtr.Zero;
		IntPtr data2 = data?.Handle ?? IntPtr.Zero;
		CFMessagePortSendRequestStatus result = CFMessagePortSendRequest(handle, msgid, data2, sendTimeout, rcvTimeout, replyMode2, ref returnData2);
		returnData = Runtime.GetINativeObject<NSData>(returnData2, owns: false);
		return result;
	}

	public CFRunLoopSource CreateRunLoopSource()
	{
		IntPtr intPtr = CFMessagePortCreateRunLoopSource(IntPtr.Zero, handle, 0);
		return new CFRunLoopSource(intPtr, ownsHandle: false);
	}

	public void SetDispatchQueue(DispatchQueue queue)
	{
		IntPtr queue2 = ((queue == null) ? IntPtr.Zero : queue.Handle);
		Check();
		CFMessagePortSetDispatchQueue(handle, queue2);
	}

	protected void Check()
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException(GetType().ToString());
		}
	}
}
