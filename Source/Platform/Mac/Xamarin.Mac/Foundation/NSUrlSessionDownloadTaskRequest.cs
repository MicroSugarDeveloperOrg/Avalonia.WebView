using System;
using System.IO;

namespace Foundation;

public class NSUrlSessionDownloadTaskRequest : IDisposable
{
	private string tmpfile;

	public NSUrl Location { get; set; }

	public NSUrlResponse Response { get; set; }

	~NSUrlSessionDownloadTaskRequest()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected void Dispose(bool disposing)
	{
		if (tmpfile != null)
		{
			try
			{
				File.Delete(tmpfile);
			}
			catch
			{
			}
			tmpfile = null;
		}
	}

	private void Initialize()
	{
		tmpfile = Path.GetTempFileName();
		File.Delete(tmpfile);
		File.Move(Location.Path, tmpfile);
		Location = NSUrl.FromFilename(tmpfile);
	}

	public NSUrlSessionDownloadTaskRequest(NSUrl location, NSUrlResponse response)
	{
		Location = location;
		Response = response;
		Initialize();
	}
}
