using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace AudioToolbox;

public abstract class AudioSource : AudioFile
{
	private static ReadProc dRead;

	private static WriteProc dWrite;

	private static GetSizeProc dGetSize;

	private static SetSizeProc dSetSize;

	private GCHandle gch;

	public abstract long Size { get; set; }

	static AudioSource()
	{
		dRead = SourceRead;
		dWrite = SourceWrite;
		dGetSize = SourceGetSize;
		dSetSize = SourceSetSize;
	}

	[MonoPInvokeCallback(typeof(ReadProc))]
	private static int SourceRead(IntPtr clientData, long inPosition, int requestCount, IntPtr buffer, out int actualCount)
	{
		AudioSource audioSource = GCHandle.FromIntPtr(clientData).Target as AudioSource;
		return (!audioSource.Read(inPosition, requestCount, buffer, out actualCount)) ? 1 : 0;
	}

	public abstract bool Read(long position, int requestCount, IntPtr buffer, out int actualCount);

	[MonoPInvokeCallback(typeof(WriteProc))]
	private static int SourceWrite(IntPtr clientData, long position, int requestCount, IntPtr buffer, out int actualCount)
	{
		AudioSource audioSource = GCHandle.FromIntPtr(clientData).Target as AudioSource;
		return (!audioSource.Write(position, requestCount, buffer, out actualCount)) ? 1 : 0;
	}

	public abstract bool Write(long position, int requestCount, IntPtr buffer, out int actualCount);

	[MonoPInvokeCallback(typeof(GetSizeProc))]
	private static long SourceGetSize(IntPtr clientData)
	{
		AudioSource audioSource = GCHandle.FromIntPtr(clientData).Target as AudioSource;
		return audioSource.Size;
	}

	[MonoPInvokeCallback(typeof(SetSizeProc))]
	private static int SourceSetSize(IntPtr clientData, long size)
	{
		AudioSource audioSource = GCHandle.FromIntPtr(clientData).Target as AudioSource;
		audioSource.Size = size;
		return 0;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (gch.IsAllocated)
		{
			gch.Free();
		}
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileInitializeWithCallbacks(IntPtr inClientData, ReadProc inReadFunc, WriteProc inWriteFunc, GetSizeProc inGetSizeFunc, SetSizeProc inSetSizeFunc, AudioFileType inFileType, ref AudioStreamBasicDescription format, uint flags, out IntPtr id);

	public AudioSource(AudioFileType inFileType, AudioStreamBasicDescription format)
		: base(x: true)
	{
		Initialize(inFileType, format);
	}

	public AudioSource()
		: base(x: true)
	{
	}

	protected void Initialize(AudioFileType inFileType, AudioStreamBasicDescription format)
	{
		gch = GCHandle.Alloc(this);
		IntPtr id;
		int num = AudioFileInitializeWithCallbacks(GCHandle.ToIntPtr(gch), dRead, dWrite, dGetSize, dSetSize, inFileType, ref format, 0u, out id);
		if (num == 0)
		{
			handle = id;
			return;
		}
		throw new Exception($"Unable to create AudioSource, code: 0x{num:x}");
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileOpenWithCallbacks(IntPtr inClientData, ReadProc inReadFunc, WriteProc inWriteFunc, GetSizeProc inGetSizeFunc, SetSizeProc inSetSizeFunc, AudioFileType inFileTypeHint, out IntPtr outAudioFile);

	public AudioSource(AudioFileType fileTypeHint)
		: base(x: true)
	{
		Open(fileTypeHint);
	}

	protected void Open(AudioFileType fileTypeHint)
	{
		gch = GCHandle.Alloc(this);
		IntPtr outAudioFile;
		int num = AudioFileOpenWithCallbacks(GCHandle.ToIntPtr(gch), dRead, dWrite, dGetSize, dSetSize, fileTypeHint, out outAudioFile);
		if (num == 0)
		{
			handle = outAudioFile;
			return;
		}
		throw new Exception($"Unable to create AudioSource, code: 0x{num:x}");
	}
}
