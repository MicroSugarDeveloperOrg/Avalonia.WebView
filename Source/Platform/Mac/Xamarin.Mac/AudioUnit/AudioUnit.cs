using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using AudioToolbox;
using Foundation;
using ObjCRuntime;

namespace AudioUnit;

public class AudioUnit : IDisposable, INativeObject
{
	internal IntPtr handle;

	private static readonly CallbackShared CreateRenderCallback = RenderCallbackImpl;

	private static readonly CallbackShared CreateInputCallback = InputCallbackImpl;

	private GCHandle gcHandle;

	private bool _isPlaying;

	private Dictionary<uint, RenderDelegate> renderer;

	private Dictionary<uint, InputDelegate> inputs;

	public IntPtr Handle => handle;

	public AudioComponent Component => new AudioComponent(AudioComponentInstanceGetComponent(handle));

	public bool IsPlaying => _isPlaying;

	internal AudioUnit(IntPtr ptr)
	{
		handle = ptr;
		gcHandle = GCHandle.Alloc(this);
	}

	public AudioUnit(AudioComponent component)
	{
		if (component == null)
		{
			throw new ArgumentNullException("component");
		}
		if (component.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("component");
		}
		int num = AudioComponentInstanceNew(component.handle, out handle);
		if (num != 0)
		{
			throw new AudioUnitException(num);
		}
		gcHandle = GCHandle.Alloc(this);
	}

	[Obsolete("Use 'SetFormat' instead as it has the ability of returning a status code.")]
	public void SetAudioFormat(AudioStreamBasicDescription audioFormat, AudioUnitScopeType scope, uint audioUnitElement = 0u)
	{
		int num = AudioUnitSetProperty(handle, AudioUnitPropertyIDType.StreamFormat, scope, audioUnitElement, ref audioFormat, (uint)Marshal.SizeOf(audioFormat));
		if (num != 0)
		{
			throw new AudioUnitException(num);
		}
	}

	public AudioUnitStatus SetFormat(AudioStreamBasicDescription audioFormat, AudioUnitScopeType scope, uint audioUnitElement = 0u)
	{
		return (AudioUnitStatus)AudioUnitSetProperty(handle, AudioUnitPropertyIDType.StreamFormat, scope, audioUnitElement, ref audioFormat, (uint)Marshal.SizeOf(audioFormat));
	}

	public uint GetCurrentDevice(AudioUnitScopeType scope, uint audioUnitElement = 0u)
	{
		uint outData = 0u;
		int ioDataSize = Marshal.SizeOf(typeof(uint));
		AudioUnitStatus audioUnitStatus = AudioUnitGetProperty(handle, AudioUnitPropertyIDType.CurrentDevice, scope, audioUnitElement, ref outData, ref ioDataSize);
		if (audioUnitStatus != 0)
		{
			throw new AudioUnitException((int)audioUnitStatus);
		}
		return outData;
	}

	public static uint GetCurrentInputDevice()
	{
		uint ioDataSize = (uint)Marshal.SizeOf(typeof(uint));
		AudioObjectPropertyAddress inAddress = new AudioObjectPropertyAddress(AudioObjectPropertySelector.DefaultInputDevice, AudioObjectPropertyScope.Global, AudioObjectPropertyElement.Master);
		uint inQualifierDataSize = 0u;
		IntPtr inQualifierData = IntPtr.Zero;
		uint outData;
		int num = AudioObjectGetPropertyData(1u, ref inAddress, ref inQualifierDataSize, ref inQualifierData, ref ioDataSize, out outData);
		if (num != 0)
		{
			throw new AudioUnitException(num);
		}
		return outData;
	}

	public AudioUnitStatus SetCurrentDevice(uint inputDevice, AudioUnitScopeType scope, uint audioUnitElement = 0u)
	{
		return AudioUnitSetProperty(handle, AudioUnitPropertyIDType.CurrentDevice, scope, audioUnitElement, ref inputDevice, (uint)Marshal.SizeOf(inputDevice));
	}

	public AudioStreamBasicDescription GetAudioFormat(AudioUnitScopeType scope, uint audioUnitElement = 0u)
	{
		AudioStreamBasicDescription outData = default(AudioStreamBasicDescription);
		uint ioDataSize = (uint)Marshal.SizeOf(outData);
		AudioUnitStatus audioUnitStatus = AudioUnitGetProperty(handle, AudioUnitPropertyIDType.StreamFormat, scope, audioUnitElement, ref outData, ref ioDataSize);
		if (audioUnitStatus != 0)
		{
			throw new AudioUnitException((int)audioUnitStatus);
		}
		return outData;
	}

	public ClassInfoDictionary GetClassInfo(AudioUnitScopeType scope = AudioUnitScopeType.Global, uint audioUnitElement = 0u)
	{
		IntPtr outData = default(IntPtr);
		int ioDataSize = Marshal.SizeOf(typeof(IntPtr));
		if (AudioUnitGetProperty(handle, AudioUnitPropertyIDType.ClassInfo, scope, audioUnitElement, ref outData, ref ioDataSize) != 0)
		{
			return null;
		}
		return new ClassInfoDictionary(new NSDictionary(outData, alloced: true));
	}

	public AudioUnitStatus SetClassInfo(ClassInfoDictionary preset, AudioUnitScopeType scope = AudioUnitScopeType.Global, uint audioUnitElement = 0u)
	{
		IntPtr inData = preset.Dictionary.Handle;
		return AudioUnitSetProperty(handle, AudioUnitPropertyIDType.ClassInfo, scope, audioUnitElement, ref inData, Marshal.SizeOf(typeof(IntPtr)));
	}

	public unsafe AudioUnitParameterInfo[] GetParameterList(AudioUnitScopeType scope = AudioUnitScopeType.Global, uint audioUnitElement = 0u)
	{
		if (AudioUnitGetPropertyInfo(handle, AudioUnitPropertyIDType.ParameterList, scope, audioUnitElement, out var outDataSize, out var _) != 0)
		{
			return null;
		}
		uint[] array = new uint[outDataSize / 4u];
		fixed (uint* outData = array)
		{
			if (AudioUnitGetProperty(handle, AudioUnitPropertyIDType.ParameterList, scope, audioUnitElement, outData, ref outDataSize) != 0)
			{
				return null;
			}
		}
		AudioUnitParameterInfo[] array2 = new AudioUnitParameterInfo[array.Length];
		outDataSize = (uint)sizeof(AudioUnitParameterInfoNative);
		for (int i = 0; i < array.Length; i++)
		{
			AudioUnitParameterInfoNative outData2 = default(AudioUnitParameterInfoNative);
			if (AudioUnitGetProperty(handle, AudioUnitPropertyIDType.ParameterInfo, scope, array[i], ref outData2, ref outDataSize) != 0)
			{
				return null;
			}
			array2[i] = AudioUnitParameterInfo.Create(outData2, (AudioUnitParameterType)array[i]);
		}
		return array2;
	}

	public AudioUnitStatus LoadInstrument(SamplerInstrumentData instrumentData, AudioUnitScopeType scope = AudioUnitScopeType.Global, uint audioUnitElement = 0u)
	{
		if (instrumentData == null)
		{
			throw new ArgumentNullException("instrumentData");
		}
		AUSamplerInstrumentData inData = instrumentData.ToStruct();
		return AudioUnitSetProperty(handle, AudioUnitPropertyIDType.LoadInstrument, scope, audioUnitElement, ref inData, Marshal.SizeOf(typeof(AUSamplerInstrumentData)));
	}

	public AudioUnitStatus MakeConnection(AudioUnit sourceAudioUnit, uint sourceOutputNumber, uint destInputNumber)
	{
		AudioUnitConnection audioUnitConnection = default(AudioUnitConnection);
		audioUnitConnection.SourceAudioUnit = sourceAudioUnit?.handle ?? IntPtr.Zero;
		audioUnitConnection.SourceOutputNumber = sourceOutputNumber;
		audioUnitConnection.DestInputNumber = destInputNumber;
		AudioUnitConnection inData = audioUnitConnection;
		return AudioUnitSetProperty(handle, AudioUnitPropertyIDType.MakeConnection, AudioUnitScopeType.Input, 0u, ref inData, Marshal.SizeOf(typeof(AudioUnitConnection)));
	}

	public AudioUnitStatus SetEnableIO(bool enableIO, AudioUnitScopeType scope, uint audioUnitElement = 0u)
	{
		uint inData = (enableIO ? 1u : 0u);
		return AudioUnitSetProperty(handle, AudioUnitPropertyIDType.EnableIO, scope, audioUnitElement, ref inData, 4u);
	}

	public AudioUnitStatus SetMaximumFramesPerSlice(uint value, AudioUnitScopeType scope, uint audioUnitElement = 0u)
	{
		return AudioUnitSetProperty(handle, AudioUnitPropertyIDType.MaximumFramesPerSlice, scope, audioUnitElement, ref value, 4u);
	}

	public uint GetMaximumFramesPerSlice(AudioUnitScopeType scope = AudioUnitScopeType.Global, uint audioUnitElement = 0u)
	{
		uint flag = 0u;
		uint ioDataSize = 4u;
		int num = AudioUnitGetProperty(handle, AudioUnitPropertyIDType.MaximumFramesPerSlice, scope, audioUnitElement, ref flag, ref ioDataSize);
		if (num != 0)
		{
			throw new AudioUnitException(num);
		}
		return flag;
	}

	public AudioUnitStatus SetElementCount(AudioUnitScopeType scope, uint count)
	{
		return AudioUnitSetProperty(handle, AudioUnitPropertyIDType.ElementCount, scope, 0u, ref count, 4u);
	}

	public uint GetElementCount(AudioUnitScopeType scope)
	{
		uint flag = 0u;
		uint ioDataSize = 4u;
		int num = AudioUnitGetProperty(handle, AudioUnitPropertyIDType.ElementCount, scope, 0u, ref flag, ref ioDataSize);
		if (num != 0)
		{
			throw new AudioUnitException(num);
		}
		return flag;
	}

	public AudioUnitStatus SetSampleRate(double sampleRate, AudioUnitScopeType scope = AudioUnitScopeType.Output, uint audioUnitElement = 0u)
	{
		return AudioUnitSetProperty(handle, AudioUnitPropertyIDType.SampleRate, scope, 0u, ref sampleRate, 8u);
	}

	public AudioUnitStatus MusicDeviceMIDIEvent(uint status, uint data1, uint data2, uint offsetSampleFrame = 0u)
	{
		return MusicDeviceMIDIEvent(handle, status, data1, data2, offsetSampleFrame);
	}

	public AudioUnitStatus SetLatency(double latency)
	{
		return AudioUnitSetProperty(handle, AudioUnitPropertyIDType.Latency, AudioUnitScopeType.Global, 0u, ref latency, 8u);
	}

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitGetProperty(IntPtr inUnit, AudioUnitPropertyIDType inID, AudioUnitScopeType inScope, uint inElement, ref double outData, ref uint ioDataSize);

	public double GetLatency()
	{
		uint ioDataSize = 8u;
		double outData = 0.0;
		AudioUnitStatus audioUnitStatus = AudioUnitGetProperty(handle, AudioUnitPropertyIDType.Latency, AudioUnitScopeType.Global, 0u, ref outData, ref ioDataSize);
		if (audioUnitStatus != 0)
		{
			throw new AudioUnitException((int)audioUnitStatus);
		}
		return outData;
	}

	public AudioUnitStatus SetRenderCallback(RenderDelegate renderDelegate, AudioUnitScopeType scope = AudioUnitScopeType.Global, uint audioUnitElement = 0u)
	{
		if (renderer == null)
		{
			Interlocked.CompareExchange(ref renderer, new Dictionary<uint, RenderDelegate>(), null);
		}
		renderer[audioUnitElement] = renderDelegate;
		AURenderCallbackStruct inData = default(AURenderCallbackStruct);
		inData.Proc = CreateRenderCallback;
		inData.ProcRefCon = GCHandle.ToIntPtr(gcHandle);
		return AudioUnitSetProperty(handle, AudioUnitPropertyIDType.SetRenderCallback, scope, audioUnitElement, ref inData, Marshal.SizeOf(inData));
	}

	[MonoPInvokeCallback(typeof(CallbackShared))]
	private static AudioUnitStatus RenderCallbackImpl(IntPtr clientData, ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timeStamp, uint busNumber, uint numberFrames, IntPtr data)
	{
		AudioUnit audioUnit = (AudioUnit)GCHandle.FromIntPtr(clientData).Target;
		Dictionary<uint, RenderDelegate> dictionary = audioUnit.renderer;
		if (dictionary == null)
		{
			return AudioUnitStatus.Uninitialized;
		}
		if (!dictionary.TryGetValue(busNumber, out var value))
		{
			return AudioUnitStatus.Uninitialized;
		}
		using AudioBuffers data2 = new AudioBuffers(data);
		return value(actionFlags, timeStamp, busNumber, numberFrames, data2);
	}

	public AudioUnitStatus SetInputCallback(InputDelegate inputDelegate, AudioUnitScopeType scope = AudioUnitScopeType.Global, uint audioUnitElement = 0u)
	{
		if (inputs == null)
		{
			Interlocked.CompareExchange(ref inputs, new Dictionary<uint, InputDelegate>(), null);
		}
		inputs[audioUnitElement] = inputDelegate;
		AURenderCallbackStruct inData = default(AURenderCallbackStruct);
		inData.Proc = CreateInputCallback;
		inData.ProcRefCon = GCHandle.ToIntPtr(gcHandle);
		return AudioUnitSetProperty(handle, AudioUnitPropertyIDType.SetInputCallback, scope, audioUnitElement, ref inData, Marshal.SizeOf(inData));
	}

	[MonoPInvokeCallback(typeof(CallbackShared))]
	private static AudioUnitStatus InputCallbackImpl(IntPtr clientData, ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timeStamp, uint busNumber, uint numberFrames, IntPtr data)
	{
		AudioUnit audioUnit = (AudioUnit)GCHandle.FromIntPtr(clientData).Target;
		Dictionary<uint, InputDelegate> dictionary = audioUnit.inputs;
		if (dictionary == null)
		{
			return AudioUnitStatus.Uninitialized;
		}
		if (!dictionary.TryGetValue(busNumber, out var value))
		{
			return AudioUnitStatus.Uninitialized;
		}
		return value(actionFlags, timeStamp, busNumber, numberFrames, audioUnit);
	}

	public int Initialize()
	{
		return AudioUnitInitialize(handle);
	}

	public int Uninitialize()
	{
		return AudioUnitUninitialize(handle);
	}

	public void Start()
	{
		if (!_isPlaying)
		{
			AudioOutputUnitStart(handle);
			_isPlaying = true;
		}
	}

	public void Stop()
	{
		if (_isPlaying)
		{
			AudioOutputUnitStop(handle);
			_isPlaying = false;
		}
	}

	public AudioUnitStatus Render(ref AudioUnitRenderActionFlags actionFlags, AudioTimeStamp timeStamp, uint busNumber, uint numberFrames, AudioBuffers data)
	{
		if ((IntPtr)data == IntPtr.Zero)
		{
			throw new ArgumentNullException("data");
		}
		return AudioUnitRender(handle, ref actionFlags, ref timeStamp, busNumber, numberFrames, (IntPtr)data);
	}

	public AudioUnitStatus SetParameter(AudioUnitParameterType type, float value, AudioUnitScopeType scope, uint audioUnitElement = 0u)
	{
		return AudioUnitSetParameter(handle, type, scope, audioUnitElement, value, 0u);
	}

	public AudioUnitStatus ScheduleParameter(AudioUnitParameterEvent inParameterEvent, uint inNumParamEvents)
	{
		return AudioUnitScheduleParameters(handle, inParameterEvent, inNumParamEvents);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern int AudioComponentInstanceDispose(IntPtr inInstance);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			Stop();
			AudioUnitUninitialize(handle);
			AudioComponentInstanceDispose(handle);
			gcHandle.Free();
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern int AudioComponentInstanceNew(IntPtr inComponent, out IntPtr inDesc);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern IntPtr AudioComponentInstanceGetComponent(IntPtr inComponent);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern int AudioUnitInitialize(IntPtr inUnit);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern int AudioUnitUninitialize(IntPtr inUnit);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern int AudioOutputUnitStart(IntPtr ci);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern int AudioOutputUnitStop(IntPtr ci);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitRender(IntPtr inUnit, ref AudioUnitRenderActionFlags ioActionFlags, ref AudioTimeStamp inTimeStamp, uint inOutputBusNumber, uint inNumberFrames, IntPtr ioData);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern int AudioUnitSetProperty(IntPtr inUnit, AudioUnitPropertyIDType inID, AudioUnitScopeType inScope, uint inElement, ref AudioStreamBasicDescription inData, uint inDataSize);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitSetProperty(IntPtr inUnit, AudioUnitPropertyIDType inID, AudioUnitScopeType inScope, uint inElement, ref uint inData, uint inDataSize);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitSetProperty(IntPtr inUnit, AudioUnitPropertyIDType inID, AudioUnitScopeType inScope, uint inElement, ref double inData, uint inDataSize);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitSetProperty(IntPtr inUnit, AudioUnitPropertyIDType inID, AudioUnitScopeType inScope, uint inElement, ref IntPtr inData, int inDataSize);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitSetProperty(IntPtr inUnit, AudioUnitPropertyIDType inID, AudioUnitScopeType inScope, uint inElement, ref AURenderCallbackStruct inData, int inDataSize);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitSetProperty(IntPtr inUnit, AudioUnitPropertyIDType inID, AudioUnitScopeType inScope, uint inElement, ref AudioUnitConnection inData, int inDataSize);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitSetProperty(IntPtr inUnit, AudioUnitPropertyIDType inID, AudioUnitScopeType inScope, uint inElement, ref AUSamplerInstrumentData inData, int inDataSize);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitGetProperty(IntPtr inUnit, AudioUnitPropertyIDType inID, AudioUnitScopeType inScope, uint inElement, ref AudioStreamBasicDescription outData, ref uint ioDataSize);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitGetProperty(IntPtr inUnit, AudioUnitPropertyIDType inID, AudioUnitScopeType inScope, uint inElement, ref IntPtr outData, ref int ioDataSize);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitGetProperty(IntPtr inUnit, AudioUnitPropertyIDType inID, AudioUnitScopeType inScope, uint inElement, ref uint outData, ref int ioDataSize);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private unsafe static extern AudioUnitStatus AudioUnitGetProperty(IntPtr inUnit, AudioUnitPropertyIDType inID, AudioUnitScopeType inScope, uint inElement, uint* outData, ref uint ioDataSize);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitGetProperty(IntPtr inUnit, AudioUnitPropertyIDType inID, AudioUnitScopeType inScope, uint inElement, ref AudioUnitParameterInfoNative outData, ref uint ioDataSize);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern int AudioUnitGetProperty(IntPtr inUnit, [MarshalAs(UnmanagedType.U4)] AudioUnitPropertyIDType inID, [MarshalAs(UnmanagedType.U4)] AudioUnitScopeType inScope, [MarshalAs(UnmanagedType.U4)] uint inElement, ref uint flag, ref uint ioDataSize);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitGetPropertyInfo(IntPtr inUnit, AudioUnitPropertyIDType inID, AudioUnitScopeType inScope, uint inElement, out uint outDataSize, [MarshalAs(UnmanagedType.I1)] out bool outWritable);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitSetParameter(IntPtr inUnit, AudioUnitParameterType inID, AudioUnitScopeType inScope, uint inElement, float inValue, uint inBufferOffsetInFrames);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitScheduleParameters(IntPtr inUnit, AudioUnitParameterEvent inParameterEvent, uint inNumParamEvents);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern int AudioObjectGetPropertyData(uint inObjectID, ref AudioObjectPropertyAddress inAddress, ref uint inQualifierDataSize, ref IntPtr inQualifierData, ref uint ioDataSize, out uint outData);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus MusicDeviceMIDIEvent(IntPtr inUnit, uint inStatus, uint inData1, uint inData2, uint inOffsetSampleFrame);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitSetProperty(IntPtr inUnit, AudioUnitPropertyIDType inID, AudioUnitScopeType inScope, uint inElement, ref AUScheduledAudioFileRegion.ScheduledAudioFileRegion inData, int inDataSize);

	public AudioUnitStatus SetScheduledFileRegion(AUScheduledAudioFileRegion region)
	{
		if (Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("AudioUnit");
		}
		if (region == null)
		{
			throw new ArgumentNullException("region");
		}
		AUScheduledAudioFileRegion.ScheduledAudioFileRegion inData = region.GetAudioFileRegion();
		return AudioUnitSetProperty(handle, AudioUnitPropertyIDType.ScheduledFileRegion, AudioUnitScopeType.Global, 0u, ref inData, Marshal.SizeOf(inData));
	}

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitSetProperty(IntPtr inUnit, AudioUnitPropertyIDType inID, AudioUnitScopeType inScope, uint inElement, ref AudioTimeStamp inData, int inDataSize);

	public AudioUnitStatus SetScheduleStartTimeStamp(AudioTimeStamp timeStamp)
	{
		if (Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("AudioUnit");
		}
		return AudioUnitSetProperty(handle, AudioUnitPropertyIDType.ScheduleStartTimeStamp, AudioUnitScopeType.Global, 0u, ref timeStamp, Marshal.SizeOf(timeStamp));
	}

	public AudioUnitStatus SetScheduledFiles(AudioFile audioFile)
	{
		if (Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("AudioUnit");
		}
		if (audioFile == null)
		{
			throw new ArgumentNullException("audioFile");
		}
		IntPtr inData = audioFile.Handle;
		return AudioUnitSetProperty(handle, AudioUnitPropertyIDType.ScheduledFileIDs, AudioUnitScopeType.Global, 0u, ref inData, Marshal.SizeOf(handle));
	}

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitSetProperty(IntPtr inUnit, AudioUnitPropertyIDType inID, AudioUnitScopeType inScope, uint inElement, IntPtr inData, int inDataSize);

	public unsafe AudioUnitStatus SetScheduledFiles(AudioFile[] audioFiles)
	{
		if (Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("AudioUnit");
		}
		if (audioFiles == null)
		{
			throw new ArgumentNullException("audioFiles");
		}
		int num = audioFiles.Length;
		IntPtr[] array = new IntPtr[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = audioFiles[i].Handle;
		}
		fixed (IntPtr* ptr = array)
		{
			return AudioUnitSetProperty(Handle, AudioUnitPropertyIDType.ScheduledFileIDs, AudioUnitScopeType.Global, 0u, (IntPtr)ptr, IntPtr.Size * num);
		}
	}
}
