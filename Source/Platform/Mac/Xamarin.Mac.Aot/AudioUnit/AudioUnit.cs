using System;
using System.Runtime.InteropServices;
using AudioToolbox;
using ObjCRuntime;

namespace AudioUnit;

public class AudioUnit : IDisposable, INativeObject
{
	[Obsolete]
	internal delegate int AURenderCallback(IntPtr inRefCon, ref AudioUnitRenderActionFlags ioActionFlags, ref AudioTimeStamp inTimeStamp, int inBusNumber, int inNumberFrames, AudioBufferList ioData);

	[StructLayout(LayoutKind.Sequential)]
	[Obsolete]
	private class AURenderCallbackStrct
	{
		public AURenderCallback inputProc;

		public IntPtr inputProcRefCon;
	}

	private static readonly RenderCallbackShared CreateRenderCallback = RenderCallbackImpl;

	private GCHandle gcHandle;

	private IntPtr handle;

	private bool _isPlaying;

	private RenderDelegate render;

	public AudioComponent Component => new AudioComponent(AudioComponentInstanceGetComponent(handle));

	public IntPtr Handle => handle;

	public bool IsPlaying => _isPlaying;

	[Obsolete("Use SetRenderCallback")]
	public event EventHandler<AudioUnitEventArgs> RenderCallback;

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
		BrokenSetRender();
	}

	[Obsolete]
	private void BrokenSetRender()
	{
		AURenderCallbackStrct aURenderCallbackStrct = new AURenderCallbackStrct();
		aURenderCallbackStrct.inputProc = renderCallback;
		aURenderCallbackStrct.inputProcRefCon = GCHandle.ToIntPtr(gcHandle);
		int num = AudioUnitSetProperty(handle, AudioUnitPropertyIDType.SetRenderCallback, AudioUnitScopeType.Input, 0u, aURenderCallbackStrct, (uint)Marshal.SizeOf(aURenderCallbackStrct));
		if (num != 0)
		{
			throw new AudioUnitException(num);
		}
	}

	[Obsolete]
	[MonoPInvokeCallback(typeof(AURenderCallback))]
	private static int renderCallback(IntPtr inRefCon, ref AudioUnitRenderActionFlags _ioActionFlags, ref AudioTimeStamp _inTimeStamp, int _inBusNumber, int _inNumberFrames, AudioBufferList _ioData)
	{
		AudioUnit audioUnit = (AudioUnit)GCHandle.FromIntPtr(inRefCon).Target;
		if (audioUnit.RenderCallback != null)
		{
			AudioUnitEventArgs e = new AudioUnitEventArgs(_ioActionFlags, _inTimeStamp, _inBusNumber, _inNumberFrames, _ioData);
			audioUnit.RenderCallback(audioUnit, e);
		}
		return 0;
	}

	public void SetAudioFormat(AudioStreamBasicDescription audioFormat, AudioUnitScopeType scope, uint audioUnitElement = 0u)
	{
		int num = AudioUnitSetProperty(handle, AudioUnitPropertyIDType.StreamFormat, scope, audioUnitElement, ref audioFormat, (uint)Marshal.SizeOf(audioFormat));
		if (num != 0)
		{
			throw new AudioUnitException(num);
		}
	}

	public AudioStreamBasicDescription GetAudioFormat(AudioUnitScopeType scope, uint audioUnitElement = 0u)
	{
		AudioStreamBasicDescription outData = default(AudioStreamBasicDescription);
		uint ioDataSize = (uint)Marshal.SizeOf(outData);
		int num = AudioUnitGetProperty(handle, AudioUnitPropertyIDType.StreamFormat, scope, audioUnitElement, ref outData, ref ioDataSize);
		if (num != 0)
		{
			throw new AudioUnitException(num);
		}
		return outData;
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

	public AudioUnitStatus SetRenderCallback(RenderDelegate renderDelegate, AudioUnitScopeType scope, uint audioUnitElement = 0u)
	{
		AURenderCallbackStruct inData = default(AURenderCallbackStruct);
		inData.Proc = CreateRenderCallback;
		inData.ProcRefCon = GCHandle.ToIntPtr(gcHandle);
		render = renderDelegate;
		return AudioUnitSetProperty(handle, AudioUnitPropertyIDType.SetRenderCallback, scope, audioUnitElement, ref inData, Marshal.SizeOf(inData));
	}

	[MonoPInvokeCallback(typeof(RenderCallbackShared))]
	private static AudioUnitStatus RenderCallbackImpl(IntPtr clientData, ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timeStamp, uint busNumber, uint numberFrames, IntPtr data)
	{
		return ((AudioUnit)GCHandle.FromIntPtr(clientData).Target).render(actionFlags, timeStamp, busNumber, numberFrames, new AudioBuffers(data));
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
		return AudioUnitRender(handle, ref actionFlags, ref timeStamp, busNumber, numberFrames, (IntPtr)data);
	}

	[Obsolete]
	public void Render(AudioUnitRenderActionFlags flags, AudioTimeStamp timeStamp, int outputBusnumber, int numberFrames, AudioBufferList data)
	{
		int num = AudioUnitRender(handle, ref flags, ref timeStamp, outputBusnumber, numberFrames, data);
		if (num != 0)
		{
			throw new AudioUnitException(num);
		}
	}

	[Obsolete]
	public AudioUnitStatus TryRender(AudioUnitRenderActionFlags flags, AudioTimeStamp timeStamp, int outputBusnumber, int numberFrames, AudioBufferList data)
	{
		return (AudioUnitStatus)AudioUnitRender(handle, ref flags, ref timeStamp, outputBusnumber, numberFrames, data);
	}

	public AudioUnitStatus SetParameter(AudioUnitParameterType type, float value, AudioUnitScopeType scope, uint audioUnitElement = 0u)
	{
		return AudioUnitSetParameter(handle, type, scope, audioUnitElement, value, 0u);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern int AudioComponentInstanceDispose(IntPtr inInstance);

	public void Dispose(bool disposing)
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
	[Obsolete]
	private static extern int AudioUnitRender(IntPtr inUnit, ref AudioUnitRenderActionFlags ioActionFlags, ref AudioTimeStamp inTimeStamp, int inOutputBusNumber, int inNumberFrames, AudioBufferList ioData);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitRender(IntPtr inUnit, ref AudioUnitRenderActionFlags ioActionFlags, ref AudioTimeStamp inTimeStamp, uint inOutputBusNumber, uint inNumberFrames, IntPtr ioData);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	[Obsolete]
	private static extern int AudioUnitSetProperty(IntPtr inUnit, [MarshalAs(UnmanagedType.U4)] AudioUnitPropertyIDType inID, [MarshalAs(UnmanagedType.U4)] AudioUnitScopeType inScope, [MarshalAs(UnmanagedType.U4)] uint inElement, AURenderCallbackStrct inData, uint inDataSize);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern int AudioUnitSetProperty(IntPtr inUnit, [MarshalAs(UnmanagedType.U4)] AudioUnitPropertyIDType inID, [MarshalAs(UnmanagedType.U4)] AudioUnitScopeType inScope, [MarshalAs(UnmanagedType.U4)] uint inElement, ref AudioStreamBasicDescription inData, uint inDataSize);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitSetProperty(IntPtr inUnit, AudioUnitPropertyIDType inID, AudioUnitScopeType inScope, uint inElement, ref uint inData, uint inDataSize);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitSetProperty(IntPtr inUnit, AudioUnitPropertyIDType inID, AudioUnitScopeType inScope, uint inElement, ref AURenderCallbackStruct inData, int inDataSize);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern int AudioUnitGetProperty(IntPtr inUnit, [MarshalAs(UnmanagedType.U4)] AudioUnitPropertyIDType inID, [MarshalAs(UnmanagedType.U4)] AudioUnitScopeType inScope, [MarshalAs(UnmanagedType.U4)] uint inElement, ref AudioStreamBasicDescription outData, ref uint ioDataSize);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern int AudioUnitGetProperty(IntPtr inUnit, [MarshalAs(UnmanagedType.U4)] AudioUnitPropertyIDType inID, [MarshalAs(UnmanagedType.U4)] AudioUnitScopeType inScope, [MarshalAs(UnmanagedType.U4)] uint inElement, ref uint flag, ref uint ioDataSize);

	[DllImport("/System/Library/Frameworks/AudioUnit.framework/AudioUnit")]
	private static extern AudioUnitStatus AudioUnitSetParameter(IntPtr inUnit, AudioUnitParameterType inID, AudioUnitScopeType inScope, uint inElement, float inValue, uint inBufferOffsetInFrames);
}
