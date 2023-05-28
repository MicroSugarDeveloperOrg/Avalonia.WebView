using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using CoreFoundation;

namespace CFNetwork;

internal class WebRequestStream
{
	private Stream stream;

	private CFReadStream readStream;

	private CFWriteStream writeStream;

	private TaskCompletionSource<object> openTcs;

	private CancellationTokenSource cts;

	private byte[] buffer;

	private bool canWrite;

	private bool open;

	private bool completed;

	private bool closed;

	private int start;

	private int position;

	private const int BufferSize = 65536;

	private const int BufferThreshold = 49152;

	private bool busy;

	public CFReadStream ReadStream => readStream;

	public WebRequestStream(Stream stream, CancellationToken cancellationToken)
	{
		this.stream = stream;
		buffer = new byte[65536];
		cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
		openTcs = new TaskCompletionSource<object>();
		cts.Token.Register(delegate
		{
			Close();
		});
		CFStream.CreateBoundPair(out readStream, out writeStream, 65536);
	}

	public async Task Open()
	{
		writeStream.OpenCompletedEvent += async delegate
		{
			open = true;
			openTcs.SetResult(null);
			if (canWrite)
			{
			    await Write();
			}
		};
		writeStream.CanAcceptBytesEvent += async delegate
		{
			if (!open)
			{
				canWrite = true;
			}
			else
			{
				await Write();
			}
		};
		writeStream.ErrorEvent += delegate
		{
			Close();
		};
		writeStream.EnableEvents(CFRunLoop.Current, CFRunLoop.ModeDefault);
		writeStream.Open();
		await openTcs.Task;
		open = true;
	}

	private async Task Write()
	{
		if (busy)
		{
			return;
		}
		busy = true;
		int available2 = position - start;
		int remainingSpace = 65536 - position;
		if (!completed && (available2 == 0 || remainingSpace >= 49152))
		{
			int ret = await stream.ReadAsync(buffer, position, remainingSpace, cts.Token);
			if (ret < 0)
			{
				Close();
				return;
			}
			if (ret == 0)
			{
				completed = true;
			}
			else
			{
				position += ret;
				available2 += ret;
			}
		}
		if (available2 == 0)
		{
			Close();
			return;
		}
		int ret2 = writeStream.Write(buffer, start, available2);
		if (ret2 <= 0)
		{
			Close();
			return;
		}
		start += ret2;
		if (start == position)
		{
			start = (position = 0);
		}
		else if (start >= 49152)
		{
			available2 = position - start;
			Buffer.BlockCopy(buffer, start, buffer, 0, available2);
			start = 0;
			position = available2;
		}
		busy = false;
	}

	private void Close()
	{
		if (!closed)
		{
			if (!open)
			{
				openTcs.SetCanceled();
			}
			closed = (completed = true);
			if (writeStream.GetStatus() != CFStreamStatus.Closed)
			{
				writeStream.Close();
			}
			writeStream.Dispose();
			stream.Dispose();
		}
	}
}
