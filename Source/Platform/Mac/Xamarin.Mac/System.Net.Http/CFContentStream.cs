using System.IO;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using CoreFoundation;
using CoreServices;

namespace System.Net.Http;

internal class CFContentStream : HttpContent
{
	private readonly CFHTTPStream http_stream;

	private BufferData data;

	private Mutex data_mutex;

	private AutoResetEvent data_event;

	private AutoResetEvent data_read_event;

	private ExceptionDispatchInfo http_exception;

	public CFContentStream(CFHTTPStream stream)
	{
		http_stream = stream;
		http_stream.ErrorEvent += HandleErrorEvent;
		data = new BufferData
		{
			Buffer = new byte[4096]
		};
		data_event = new AutoResetEvent(initialState: false);
		data_read_event = new AutoResetEvent(initialState: true);
		data_mutex = new Mutex();
	}

	private void HandleErrorEvent(object sender, CFStream.StreamEventArgs e)
	{
		if (data_mutex.WaitOne())
		{
			CFHTTPStream cFHTTPStream = (CFHTTPStream)sender;
			if (e.EventType == CFStreamEventType.ErrorOccurred)
			{
				Volatile.Write(ref http_exception, ExceptionDispatchInfo.Capture(cFHTTPStream.GetError()));
			}
			data_mutex.ReleaseMutex();
		}
	}

	public void ReadStreamData()
	{
		data_read_event.WaitOne();
		data_mutex.WaitOne();
		data.Length = (int)http_stream.Read(data.Buffer, 0, data.Buffer.Length);
		data_mutex.ReleaseMutex();
		data_event.Set();
	}

	public void Close()
	{
		data_read_event.WaitOne();
		data_mutex.WaitOne();
		data = null;
		http_stream.ErrorEvent -= HandleErrorEvent;
		data_mutex.ReleaseMutex();
		data_event.Set();
	}

	protected override async Task SerializeToStreamAsync(Stream stream, TransportContext context)
	{
		while (data_event.WaitOne())
		{
			data_mutex.WaitOne();
			if (http_exception != null)
			{
				http_exception.Throw();
				data_mutex.ReleaseMutex();
				break;
			}
			if (data == null || data.Length <= 0)
			{
				data_mutex.ReleaseMutex();
				data_read_event.Set();
				break;
			}
			await stream.WriteAsync(data.Buffer, 0, data.Length).ConfigureAwait(continueOnCapturedContext: false);
			data_mutex.ReleaseMutex();
			data_read_event.Set();
		}
	}

    protected override bool TryComputeLength(out long length)
    {
        length = 0L;
        return false;
    }
}
