using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AudioToolbox;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace AudioUnit;

public class AUGraph : INativeObject, IDisposable
{
	private readonly GCHandle gcHandle;

	private IntPtr handle;

	private HashSet<RenderDelegate> graphUserCallbacks = new HashSet<RenderDelegate>();

	private Dictionary<uint, RenderDelegate> nodesCallbacks;

	private static readonly CallbackShared CreateRenderCallback = RenderCallbackImpl;

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

	[Preserve(Conditional = true)]
	internal AUGraph(IntPtr handle, bool owns)
	{
		this.handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(this.handle);
		}
		gcHandle = GCHandle.Alloc(this);
	}

	internal AUGraph(IntPtr ptr)
	{
		handle = ptr;
		gcHandle = GCHandle.Alloc(this);
	}

	public AUGraph()
	{
		int num = NewAUGraph(ref handle);
		if (num != 0)
		{
			throw new InvalidOperationException($"Cannot create new AUGraph. Error code: {num}");
		}
		gcHandle = GCHandle.Alloc(this);
	}

	public static AUGraph Create(out int errorCode)
	{
		IntPtr outGraph = IntPtr.Zero;
		errorCode = NewAUGraph(ref outGraph);
		if (errorCode != 0)
		{
			return null;
		}
		return new AUGraph(outGraph);
	}

	public AudioUnitStatus AddRenderNotify(RenderDelegate callback)
	{
		if (callback == null)
		{
			throw new ArgumentException("Callback can not be null");
		}
		AudioUnitStatus audioUnitStatus = AudioUnitStatus.NoError;
		if (graphUserCallbacks.Count == 0)
		{
			audioUnitStatus = (AudioUnitStatus)AUGraphAddRenderNotify(handle, renderCallback, GCHandle.ToIntPtr(gcHandle));
		}
		if (audioUnitStatus == AudioUnitStatus.NoError)
		{
			graphUserCallbacks.Add(callback);
		}
		return audioUnitStatus;
	}

	public AudioUnitStatus RemoveRenderNotify(RenderDelegate callback)
	{
		if (callback == null)
		{
			throw new ArgumentException("Callback can not be null");
		}
		if (!graphUserCallbacks.Contains(callback))
		{
			throw new ArgumentException("Cannot unregister a callback that has not been registered");
		}
		AudioUnitStatus result = AudioUnitStatus.NoError;
		if (graphUserCallbacks.Count == 0)
		{
			result = (AudioUnitStatus)AUGraphRemoveRenderNotify(handle, renderCallback, GCHandle.ToIntPtr(gcHandle));
		}
		graphUserCallbacks.Remove(callback);
		return result;
	}

	[MonoPInvokeCallback(typeof(CallbackShared))]
	private static AudioUnitStatus renderCallback(IntPtr inRefCon, ref AudioUnitRenderActionFlags _ioActionFlags, ref AudioTimeStamp _inTimeStamp, uint _inBusNumber, uint _inNumberFrames, IntPtr _ioData)
	{
		AUGraph aUGraph = (AUGraph)GCHandle.FromIntPtr(inRefCon).Target;
		HashSet<RenderDelegate> hashSet = aUGraph.graphUserCallbacks;
		if (hashSet.Count != 0)
		{
			using (AudioBuffers data = new AudioBuffers(_ioData))
			{
				foreach (RenderDelegate item in hashSet)
				{
					item(_ioActionFlags, _inTimeStamp, _inBusNumber, _inNumberFrames, data);
				}
				return AudioUnitStatus.NoError;
			}
		}
		return AudioUnitStatus.InvalidParameter;
	}

	public void Open()
	{
		int num = AUGraphOpen(handle);
		if (num != 0)
		{
			throw new InvalidOperationException($"Cannot open AUGraph. Error code: {num}");
		}
	}

	public int TryOpen()
	{
		return AUGraphOpen(handle);
	}

	public int AddNode(AudioComponentDescription description)
	{
		int outNode;
		AUGraphError aUGraphError = AUGraphAddNode(handle, ref description, out outNode);
		if (aUGraphError != 0)
		{
			throw new ArgumentException($"Error code: {aUGraphError}");
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
		AUGraphError error;
		AudioUnit nodeInfo = GetNodeInfo(node, out error);
		if (error != 0)
		{
			throw new ArgumentException($"Error code:{error}");
		}
		if (nodeInfo == null)
		{
			throw new InvalidOperationException("Can not get object instance");
		}
		return nodeInfo;
	}

	public AudioUnit GetNodeInfo(int node, out AUGraphError error)
	{
		if (Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("AUGraph");
		}
		error = AUGraphNodeInfo(handle, node, IntPtr.Zero, out var outAudioUnit);
		if (error != 0 || outAudioUnit == IntPtr.Zero)
		{
			return null;
		}
		return new AudioUnit(outAudioUnit);
	}

	public AudioUnit GetNodeInfo(int node, out AudioComponentDescription cd, out AUGraphError error)
	{
		if (Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("AUGraph");
		}
		error = AUGraphNodeInfo(Handle, node, out cd, out var outAudioUnit);
		if (error != 0 || outAudioUnit == IntPtr.Zero)
		{
			return null;
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

	public AUGraphError SetNodeInputCallback(int destNode, uint destInputNumber, RenderDelegate renderDelegate)
	{
		if (nodesCallbacks == null)
		{
			nodesCallbacks = new Dictionary<uint, RenderDelegate>();
		}
		nodesCallbacks[destInputNumber] = renderDelegate;
		AURenderCallbackStruct inInputCallback = default(AURenderCallbackStruct);
		inInputCallback.Proc = CreateRenderCallback;
		inInputCallback.ProcRefCon = GCHandle.ToIntPtr(gcHandle);
		return AUGraphSetNodeInputCallback(handle, destNode, destInputNumber, ref inInputCallback);
	}

	[MonoPInvokeCallback(typeof(CallbackShared))]
	private static AudioUnitStatus RenderCallbackImpl(IntPtr clientData, ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timeStamp, uint busNumber, uint numberFrames, IntPtr data)
	{
		AUGraph aUGraph = (AUGraph)GCHandle.FromIntPtr(clientData).Target;
		if (!aUGraph.nodesCallbacks.TryGetValue(busNumber, out var value))
		{
			return AudioUnitStatus.InvalidParameter;
		}
		using AudioBuffers data2 = new AudioBuffers(data);
		return value(actionFlags, timeStamp, busNumber, numberFrames, data2);
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

	public void LogAllNodes()
	{
		if (Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("AUGraph");
		}
		CAShow(Handle);
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
	private static extern AUGraphError AUGraphAddNode(IntPtr inGraph, ref AudioComponentDescription inDescription, out int outNode);

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
	private static extern int AUGraphAddRenderNotify(IntPtr inGraph, CallbackShared inCallback, IntPtr inRefCon);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AUGraphRemoveRenderNotify(IntPtr inGraph, CallbackShared inCallback, IntPtr inRefCon);

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

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern void CAShow(IntPtr handle);
}
