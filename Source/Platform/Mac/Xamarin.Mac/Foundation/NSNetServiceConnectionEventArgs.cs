using System;

namespace Foundation;

public class NSNetServiceConnectionEventArgs : EventArgs
{
	public NSInputStream InputStream { get; set; }

	public NSOutputStream OutputStream { get; set; }

	public NSNetServiceConnectionEventArgs(NSInputStream inputStream, NSOutputStream outputStream)
	{
		InputStream = inputStream;
		OutputStream = outputStream;
	}
}
