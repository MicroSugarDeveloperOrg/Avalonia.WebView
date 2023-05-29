using System;
using System.Runtime.InteropServices;
using AudioToolbox;
using Foundation;

namespace AudioUnit;

public class AUGraph : IDisposable
{
	private readonly GCHandle gcHandle;

	private IntPtr handle;

	[Advice("Use Handle property instead")]
	public IntPtr Handler => handle;

	public IntPtr Handle => handle;

	public bool IsInitialized
	{
		get
		{
			bool outIsInitialized;
			return AUGraphIsInitialized(handle, out outIsInitialized) == AUGraphError.OK && outIsInitialized;
		}
	}

	public bool IsOpen
	{
		get
		{
			bool outIsOpen;
			return AUGraphIsOpen(handle, out outIsOpen) == AUGraphError.OK && outIsOpen;
		}
	}

	public bool IsRunning
	{
		get
		{
			bool outIsRunning;
			return AUGraphIsRunning(handle, out outIsRunning) == AUGraphError.OK && outIsRunning;
		}
	}

	public event EventHandler<AudioGraphEventArgs> RenderCallback;

	internal AUGraph(IntPtr ptr)
	{
		handle = ptr;
		int num = AUGraphAddRenderNotify(handle, renderCallback, GCHandle.ToIntPtr(gcHandle));
		if (num != 0)
		{
			throw new ArgumentException($"Error code: {num}");
		}
		gcHandle = GCHandle.Alloc(this);
	}

	public AUGraph()
	{
		int num = NewAUGraph(ref handle);
		if (num != 0)
		{
			throw new InvalidOperationException(string.Format("Cannot create new AUGraph. Error code:", num));
		}
	}

	[MonoPInvokeCallback(typeof(AudioUnit.AURenderCallback))]
	private static int renderCallback(IntPtr inRefCon, ref AudioUnitRenderActionFlags _ioActionFlags, ref AudioTimeStamp _inTimeStamp, int _inBusNumber, int _inNumberFrames, AudioBufferList _ioData)
	{
		AUGraph aUGraph = (AUGraph)GCHandle.FromIntPtr(inRefCon).Target;
		if (aUGraph.RenderCallback != null)
		{
			AudioGraphEventArgs e = new AudioGraphEventArgs(_ioActionFlags, _inTimeStamp, _inBusNumber, _inNumberFrames, _ioData);
			aUGraph.RenderCallback(aUGraph, e);
		}
		return 0;
	}

	public void Open()
	{
		int num = AUGraphOpen(handle);
		if (num != 0)
		{
			throw new InvalidOperationException(string.Format("Cannot open AUGraph. Error code:", num));
		}
	}

	public int TryOpen()
	{
		return AUGraphOpen(handle);
	}

	public int AddNode(AudioComponentDescription description)
	{
		int outNode;
		AUGraphError aUGraphError = AUGraphAddNode(handle, description, out outNode);
		if (aUGraphError != 0)
		{
			throw new ArgumentException(string.Format("Error code:", aUGraphError));
		}
		return outNode;
	}

	public AUGraphError RemoveNode(int node)
	{
		return AUGraphRemoveNode(handle, node);
	}

	public AUGraphError GetCPULoad(out float averageCPULoad)
	{
		return AUGraphGetCPULoad(handle, out averageCPULoad);
	}

	public AUGraphError GetMaxCPULoad(out float maxCPULoad)
	{
		return AUGraphGetMaxCPULoad(handle, out maxCPULoad);
	}

	public AUGraphError GetNode(uint index, out int node)
	{
		return AUGraphGetIndNode(handle, index, out node);
	}

	public AUGraphError GetNodeCount(out int count)
	{
		return AUGraphGetNodeCount(handle, out count);
	}

	public AudioUnit GetNodeInfo(int node)
	{
		IntPtr outAudioUnit;
		AUGraphError aUGraphError = AUGraphNodeInfo(handle, node, IntPtr.Zero, out outAudioUnit);
		if (aUGraphError != 0)
		{
			throw new ArgumentException($"Error code:{aUGraphError}");
		}
		if (outAudioUnit == IntPtr.Zero)
		{
			throw new InvalidOperationException("Can not get object instance");
		}
		return new AudioUnit(outAudioUnit);
	}

	public AUGraphError GetNumberOfInteractions(out uint interactionsCount)
	{
		return AUGraphGetNumberOfInteractions(handle, out interactionsCount);
	}

	public AUGraphError GetNumberOfInteractions(int node, out uint interactionsCount)
	{
		return AUGraphCountNodeInteractions(handle, node, out interactionsCount);
	}

	public AUGraphError ConnnectNodeInput(int sourceNode, uint sourceOutputNumber, int destNode, uint destInputNumber)
	{
		return AUGraphConnectNodeInput(handle, sourceNode, sourceOutputNumber, destNode, destInputNumber);
	}

	public AUGraphError DisconnectNodeInput(int destNode, uint destInputNumber)
	{
		return AUGraphDisconnectNodeInput(handle, destNode, destInputNumber);
	}

	public AUGraphError ClearConnections()
	{
		return AUGraphClearConnections(handle);
	}

	public AUGraphError Start()
	{
		return AUGraphStart(handle);
	}

	public AUGraphError Stop()
	{
		return AUGraphStop(handle);
	}

	public AUGraphError Initialize()
	{
		return AUGraphInitialize(handle);
	}

	public bool Update()
	{
		bool outIsUpdated;
		return AUGraphUpdate(handle, out outIsUpdated) == AUGraphError.OK && outIsUpdated;
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
			AUGraphUninitialize(handle);
			AUGraphClose(handle);
			DisposeAUGraph(handle);
			gcHandle.Free();
			handle = IntPtr.Zero;
		}
	}

	~AUGraph()
	{
		Dispose(disposing: false);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int NewAUGraph(ref IntPtr outGraph);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AUGraphOpen(IntPtr inGraph);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphAddNode(IntPtr inGraph, AudioComponentDescription inDescription, out int outNode);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphRemoveNode(IntPtr inGraph, int inNode);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphGetNodeCount(IntPtr inGraph, out int outNumberOfNodes);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphGetIndNode(IntPtr inGraph, uint inIndex, out int outNode);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphNodeInfo(IntPtr inGraph, int inNode, IntPtr outDescription, out IntPtr outAudioUnit);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphNodeInfo(IntPtr inGraph, int inNode, out AudioComponentDescription outDescription, out IntPtr outAudioUnit);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphClearConnections(IntPtr inGraph);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphConnectNodeInput(IntPtr inGraph, int inSourceNode, uint inSourceOutputNumber, int inDestNode, uint inDestInputNumber);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphDisconnectNodeInput(IntPtr inGraph, int inDestNode, uint inDestInputNumber);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphGetNumberOfInteractions(IntPtr inGraph, out uint outNumInteractions);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphCountNodeInteractions(IntPtr inGraph, int inNode, out uint outNumInteractions);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphInitialize(IntPtr inGraph);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AUGraphAddRenderNotify(IntPtr inGraph, AudioUnit.AURenderCallback inCallback, IntPtr inRefCon);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphStart(IntPtr inGraph);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphStop(IntPtr inGraph);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphUninitialize(IntPtr inGraph);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AUGraphClose(IntPtr inGraph);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int DisposeAUGraph(IntPtr inGraph);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphIsOpen(IntPtr inGraph, out bool outIsOpen);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphIsInitialized(IntPtr inGraph, out bool outIsInitialized);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphIsRunning(IntPtr inGraph, out bool outIsRunning);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphGetCPULoad(IntPtr inGraph, out float outAverageCPULoad);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphGetMaxCPULoad(IntPtr inGraph, out float outMaxLoad);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphSetNodeInputCallback(IntPtr inGraph, int inDestNode, uint inDestInputNumber, ref AURenderCallbackStruct inInputCallback);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AUGraphError AUGraphUpdate(IntPtr inGraph, out bool outIsUpdated);
}
