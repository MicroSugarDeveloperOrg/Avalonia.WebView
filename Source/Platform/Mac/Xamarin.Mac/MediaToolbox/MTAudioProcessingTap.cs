using System.Collections.Generic;
using System.Runtime.InteropServices;
using AudioToolbox;
using CoreFoundation;
using CoreMedia;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MediaToolbox;

[iOS(6, 0)]
[Mac(10, 9)]
public class MTAudioProcessingTap : INativeObject, IDisposable
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Callbacks
	{
		private int version;

		public IntPtr clientInfo;

		public MTAudioProcessingTapInitCallbackProxy init;

		public Action<IntPtr> finalize;

		public MTAudioProcessingTapPrepareCallbackProxy prepare;

		public Action<IntPtr> unprepare;

		public MTAudioProcessingTapProcessCallbackProxy process;
	}

	private unsafe delegate void MTAudioProcessingTapInitCallbackProxy(IntPtr tap, IntPtr clientInfo, out void* tapStorageOut);

	private delegate void MTAudioProcessingTapProcessCallbackProxy(IntPtr tap, IntPtr numberFrames, MTAudioProcessingTapFlags flags, IntPtr bufferListInOut, out IntPtr numberFramesOut, out MTAudioProcessingTapFlags flagsOut);

	private delegate void MTAudioProcessingTapPrepareCallbackProxy(IntPtr tap, IntPtr maxFrames, ref AudioStreamBasicDescription processingFormat);

	private static readonly Dictionary<IntPtr, MTAudioProcessingTap> handles = new Dictionary<IntPtr, MTAudioProcessingTap>(Runtime.IntPtrEqualityComparer);

	private IntPtr handle;

	private MTAudioProcessingTapCallbacks callbacks;

	private GCHandle gch;

	public IntPtr Handle => handle;

	internal static MTAudioProcessingTap FromHandle(IntPtr handle)
	{
		lock (handles)
		{
			if (handles.TryGetValue(handle, out var value))
			{
				return value;
			}
			return null;
		}
	}

	[DllImport("/System/Library/Frameworks/MediaToolbox.framework/MediaToolbox")]
	private static extern MTAudioProcessingTapError MTAudioProcessingTapCreate(IntPtr allocator, ref Callbacks callbacks, MTAudioProcessingTapCreationFlags flags, out IntPtr tapOut);

	public unsafe MTAudioProcessingTap(MTAudioProcessingTapCallbacks callbacks, MTAudioProcessingTapCreationFlags flags)
	{
		if (callbacks == null)
		{
			throw new ArgumentNullException("callbacks");
		}
		if ((flags & (MTAudioProcessingTapCreationFlags.PreEffects | MTAudioProcessingTapCreationFlags.PostEffects)) == (MTAudioProcessingTapCreationFlags.PreEffects | MTAudioProcessingTapCreationFlags.PostEffects))
		{
			throw new ArgumentException("Only one effect type can be set");
		}
		this.callbacks = callbacks;
		Callbacks callbacks2 = default(Callbacks);
		if (callbacks.Initialize != null)
		{
			callbacks2.init = InitializeProxy;
		}
		if (callbacks.Finalize != null)
		{
			callbacks2.finalize = FinalizeProxy;
		}
		if (callbacks.Prepare != null)
		{
			callbacks2.prepare = PrepareProxy;
		}
		if (callbacks.Unprepare != null)
		{
			callbacks2.unprepare = UnprepareProxy;
		}
		callbacks2.process = ProcessProxy;
		gch = GCHandle.Alloc(this);
		callbacks2.clientInfo = (IntPtr)gch;
		MTAudioProcessingTapError mTAudioProcessingTapError = MTAudioProcessingTapCreate(IntPtr.Zero, ref callbacks2, flags, out handle);
		gch.Free();
		if (mTAudioProcessingTapError != 0)
		{
			throw new ArgumentException(mTAudioProcessingTapError.ToString());
		}
		lock (handles)
		{
			handles[handle] = this;
		}
	}

	~MTAudioProcessingTap()
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
			lock (handles)
			{
				handles.Remove(handle);
			}
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/MediaToolbox.framework/MediaToolbox")]
	private unsafe static extern void* MTAudioProcessingTapGetStorage(IntPtr tap);

	public unsafe void* GetStorage()
	{
		return MTAudioProcessingTapGetStorage(handle);
	}

	[DllImport("/System/Library/Frameworks/MediaToolbox.framework/MediaToolbox")]
	private static extern MTAudioProcessingTapError MTAudioProcessingTapGetSourceAudio(IntPtr tap, IntPtr numberFrames, IntPtr bufferListInOut, out MTAudioProcessingTapFlags flagsOut, out CMTimeRange timeRangeOut, out IntPtr numberFramesOut);

	public MTAudioProcessingTapError GetSourceAudio(nint frames, AudioBuffers bufferList, out MTAudioProcessingTapFlags flags, out CMTimeRange timeRange, out nint framesProvided)
	{
		if (bufferList == null)
		{
			throw new ArgumentNullException("bufferList");
		}
		IntPtr numberFramesOut;
		MTAudioProcessingTapError result = MTAudioProcessingTapGetSourceAudio(handle, (IntPtr)frames, (IntPtr)bufferList, out flags, out timeRange, out numberFramesOut);
		framesProvided = (nint)numberFramesOut;
		return result;
	}

	[MonoPInvokeCallback(typeof(MTAudioProcessingTapInitCallbackProxy))]
	private unsafe static void InitializeProxy(IntPtr tap, IntPtr clientInfo, out void* tapStorage)
	{
		MTAudioProcessingTap mTAudioProcessingTap = (MTAudioProcessingTap)GCHandle.FromIntPtr(clientInfo).Target;
		mTAudioProcessingTap.callbacks.Initialize(mTAudioProcessingTap, out tapStorage);
	}

	[MonoPInvokeCallback(typeof(MTAudioProcessingTapProcessCallbackProxy))]
	private static void ProcessProxy(IntPtr tap, IntPtr numberFrames, MTAudioProcessingTapFlags flags, IntPtr bufferList, out IntPtr numberFramesOut, out MTAudioProcessingTapFlags flagsOut)
	{
		MTAudioProcessingTap mTAudioProcessingTap;
		lock (handles)
		{
			mTAudioProcessingTap = handles[tap];
		}
		mTAudioProcessingTap.callbacks.Processing(mTAudioProcessingTap, (nint)numberFrames, flags, new AudioBuffers(bufferList), out var numberFramesOut2, out flagsOut);
		numberFramesOut = (IntPtr)numberFramesOut2;
	}

	[MonoPInvokeCallback(typeof(Action<IntPtr>))]
	private static void FinalizeProxy(IntPtr tap)
	{
		MTAudioProcessingTap mTAudioProcessingTap;
		lock (handles)
		{
			mTAudioProcessingTap = handles[tap];
		}
		mTAudioProcessingTap.callbacks.Finalize(mTAudioProcessingTap);
	}

	[MonoPInvokeCallback(typeof(MTAudioProcessingTapPrepareCallbackProxy))]
	private static void PrepareProxy(IntPtr tap, IntPtr maxFrames, ref AudioStreamBasicDescription processingFormat)
	{
		MTAudioProcessingTap mTAudioProcessingTap;
		lock (handles)
		{
			mTAudioProcessingTap = handles[tap];
		}
		mTAudioProcessingTap.callbacks.Prepare(mTAudioProcessingTap, (nint)maxFrames, ref processingFormat);
	}

	[MonoPInvokeCallback(typeof(Action<IntPtr>))]
	private static void UnprepareProxy(IntPtr tap)
	{
		MTAudioProcessingTap mTAudioProcessingTap;
		lock (handles)
		{
			mTAudioProcessingTap = handles[tap];
		}
		mTAudioProcessingTap.callbacks.Unprepare(mTAudioProcessingTap);
	}
}
