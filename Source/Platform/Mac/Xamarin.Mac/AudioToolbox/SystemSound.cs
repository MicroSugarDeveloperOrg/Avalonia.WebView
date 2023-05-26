using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace AudioToolbox;

public class SystemSound : INativeObject, IDisposable
{
	private uint soundId;

	private bool ownsHandle;

	private Action completionRoutine;

	private GCHandle gc_handle;

	private static readonly Action<SystemSoundId, IntPtr> SoundCompletionCallback = SoundCompletionShared;

	public IntPtr Handle
	{
		get
		{
			AssertNotDisposed();
			return (IntPtr)soundId;
		}
	}

	public bool IsUISound
	{
		get
		{
			uint propertyDataSize = 4u;
			uint propertyData;
			AudioServicesError audioServicesError = AudioServices.AudioServicesGetProperty(AudioServicesPropertyKey.IsUISound, 4u, ref soundId, out propertyDataSize, out propertyData);
			if (audioServicesError != 0)
			{
				throw new ArgumentException(audioServicesError.ToString());
			}
			return propertyData == 1;
		}
		set
		{
			uint propertyData = (value ? 1u : 0u);
			AudioServicesError audioServicesError = AudioServices.AudioServicesSetProperty(AudioServicesPropertyKey.IsUISound, 4u, ref soundId, 4u, ref propertyData);
			if (audioServicesError != 0)
			{
				throw new ArgumentException(audioServicesError.ToString());
			}
		}
	}

	public bool CompletePlaybackIfAppDies
	{
		get
		{
			uint propertyDataSize = 4u;
			uint propertyData;
			AudioServicesError audioServicesError = AudioServices.AudioServicesGetProperty(AudioServicesPropertyKey.CompletePlaybackIfAppDies, 4u, ref soundId, out propertyDataSize, out propertyData);
			if (audioServicesError != 0)
			{
				throw new ArgumentException(audioServicesError.ToString());
			}
			return propertyData == 1;
		}
		set
		{
			uint propertyData = (value ? 1u : 0u);
			AudioServicesError audioServicesError = AudioServices.AudioServicesSetProperty(AudioServicesPropertyKey.CompletePlaybackIfAppDies, 4u, ref soundId, 4u, ref propertyData);
			if (audioServicesError != 0)
			{
				throw new ArgumentException(audioServicesError.ToString());
			}
		}
	}

	internal SystemSound(uint soundId, bool ownsHandle)
	{
		this.soundId = soundId;
		this.ownsHandle = ownsHandle;
	}

	~SystemSound()
	{
		Dispose(disposing: false);
	}

	private void AssertNotDisposed()
	{
		if (soundId == 0)
		{
			throw new ObjectDisposedException("SystemSound");
		}
	}

	void IDisposable.Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		Cleanup(checkForError: false);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioServicesError AudioServicesDisposeSystemSoundID(uint soundId);

	private void Cleanup(bool checkForError)
	{
		if (soundId != 0 && ownsHandle)
		{
			if (gc_handle.IsAllocated)
			{
				gc_handle.Free();
			}
			if (completionRoutine != null)
			{
				RemoveSystemSoundCompletion();
			}
			AudioServicesError audioServicesError = AudioServicesDisposeSystemSoundID(soundId);
			uint num = soundId;
			soundId = 0u;
			if (checkForError && audioServicesError != 0)
			{
				throw new InvalidOperationException($"Error while disposing SystemSound with ID {num}: {audioServicesError.ToString()}");
			}
		}
	}

	public void Close()
	{
		Cleanup(checkForError: true);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern void AudioServicesPlayAlertSound(uint inSystemSoundID);

	public void PlayAlertSound()
	{
		AssertNotDisposed();
		AudioServicesPlayAlertSound(soundId);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern void AudioServicesPlaySystemSound(uint inSystemSoundID);

	public void PlaySystemSound()
	{
		AssertNotDisposed();
		AudioServicesPlaySystemSound(soundId);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioServicesError AudioServicesCreateSystemSoundID(IntPtr fileUrl, out uint soundId);

	public SystemSound(NSUrl fileUrl)
	{
		AudioServicesError audioServicesError = AudioServicesCreateSystemSoundID(fileUrl.Handle, out soundId);
		if (audioServicesError != 0)
		{
			throw new InvalidOperationException($"Could not create system sound ID for url {fileUrl}; error={audioServicesError}");
		}
		ownsHandle = true;
	}

	public static SystemSound FromFile(NSUrl fileUrl)
	{
		if (AudioServicesCreateSystemSoundID(fileUrl.Handle, out var num) != 0)
		{
			return null;
		}
		return new SystemSound(num, ownsHandle: true);
	}

	public static SystemSound FromFile(string filename)
	{
		using NSUrl nSUrl = new NSUrl(filename);
		if (AudioServicesCreateSystemSoundID(nSUrl.Handle, out var num) != 0)
		{
			return null;
		}
		return new SystemSound(num, ownsHandle: true);
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioServicesError AudioServicesAddSystemSoundCompletion(uint soundId, IntPtr runLoop, IntPtr runLoopMode, Action<SystemSoundId, IntPtr> completionRoutine, IntPtr clientData);

	[MonoPInvokeCallback(typeof(Action<SystemSoundId, IntPtr>))]
	private static void SoundCompletionShared(SystemSoundId id, IntPtr clientData)
	{
		((SystemSound)GCHandle.FromIntPtr(clientData).Target).completionRoutine();
	}

	public AudioServicesError AddSystemSoundCompletion(Action routine, CFRunLoop runLoop = null)
	{
		if (gc_handle.IsAllocated)
		{
			throw new ArgumentException("Only single completion routine is supported");
		}
		gc_handle = GCHandle.Alloc(this);
		completionRoutine = routine;
		return AudioServicesAddSystemSoundCompletion(soundId, (runLoop == null) ? IntPtr.Zero : runLoop.Handle, IntPtr.Zero, SoundCompletionCallback, GCHandle.ToIntPtr(gc_handle));
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern void AudioServicesRemoveSystemSoundCompletion(uint soundId);

	public void RemoveSystemSoundCompletion()
	{
		completionRoutine = null;
		AudioServicesRemoveSystemSoundCompletion(soundId);
	}
}
