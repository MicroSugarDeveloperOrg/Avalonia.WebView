using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
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

	private static readonly Action<IntPtr> static_action = TrampolineAction;

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

	public SystemSound(uint soundId)
		: this(soundId, ownsHandle: false)
	{
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

	public void Dispose()
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

	[MonoPInvokeCallback(typeof(Action<IntPtr>))]
	private unsafe static void TrampolineAction(IntPtr blockPtr)
	{
		BlockLiteral* ptr = (BlockLiteral*)(void*)blockPtr;
		((Action)ptr->Target)?.Invoke();
	}

	[iOS(9, 0)]
	[Mac(10, 11)]
	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe void PlayAlertSound(Action onCompletion)
	{
		if (onCompletion == null)
		{
			throw new ArgumentNullException("onCompletion");
		}
		AssertNotDisposed();
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(static_action, onCompletion);
		AudioServicesPlayAlertSoundWithCompletion(soundId, ptr);
		ptr->CleanupBlock();
	}

	[iOS(9, 0)]
	[Mac(10, 11)]
	public Task PlayAlertSoundAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		PlayAlertSound(delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[iOS(9, 0)]
	[Mac(10, 11)]
	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe void PlaySystemSound(Action onCompletion)
	{
		if (onCompletion == null)
		{
			throw new ArgumentNullException("onCompletion");
		}
		AssertNotDisposed();
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(static_action, onCompletion);
		AudioServicesPlaySystemSoundWithCompletion(soundId, ptr);
		ptr->CleanupBlock();
	}

	[iOS(9, 0)]
	[Mac(10, 11)]
	public Task PlaySystemSoundAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		PlaySystemSound(delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	private unsafe static extern void AudioServicesPlayAlertSoundWithCompletion(uint inSystemSoundID, BlockLiteral* inCompletionBlock);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	private unsafe static extern void AudioServicesPlaySystemSoundWithCompletion(uint inSystemSoundID, BlockLiteral* inCompletionBlock);

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
		SystemSound systemSound = (SystemSound)GCHandle.FromIntPtr(clientData).Target;
		systemSound.completionRoutine();
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
