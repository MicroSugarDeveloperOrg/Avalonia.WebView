using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CFNetwork;

internal class Content : StreamContent
{
	private WebResponseStream responseStream;

	private long? contentLength;

	internal Content(WebResponseStream stream)
		: base(stream)
	{
		responseStream = stream;
	}

    protected internal new bool TryComputeLength(out long length)
    {
        length = contentLength.GetValueOrDefault();
        return contentLength.HasValue;
    }


    protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (responseStream != null)
			{
				responseStream.Dispose();
			}
			responseStream = null;
		}
	}

	internal bool DecodeHeader(string key, string value)
	{
		if (key.Equals("Content-Type"))
		{
			SetContentType(value);
			return true;
		}
		if (key.EndsWith("Content-Length", StringComparison.Ordinal))
		{
			SetContentLength(value);
			return true;
		}
		if (key.EndsWith("Content-Language", StringComparison.Ordinal))
		{
			base.Headers.ContentLanguage.Add(value);
			return true;
		}
		if (key.Equals("Content-Location"))
		{
			base.Headers.ContentLocation = new Uri(value);
			return true;
		}
		if (key.Equals("Allow"))
		{
			DecodeAllow(value);
			return true;
		}
		if (key.Equals("Expires"))
		{
			DecodeExpires(value);
			return true;
		}
		if (key.Equals("Last-Modified"))
		{
			DecodeLastModified(value);
			return true;
		}
		return false;
	}

	private void SetContentType(string value)
	{
		int num = value.IndexOf(';');
		string mediaType = ((num >= 0) ? value.Substring(0, num).Trim() : value.Trim());
		base.Headers.ContentType = new MediaTypeHeaderValue(mediaType);
		if (num >= 0)
		{
			value = value.Substring(num + 1).Trim();
			if (value.StartsWith("charset=", StringComparison.Ordinal))
			{
				string item = value.Substring(8);
				base.Headers.ContentEncoding.Add(item);
			}
		}
	}

	private void SetContentLength(string value)
	{
		contentLength = long.Parse(value);
		base.Headers.ContentLength = contentLength;
	}

	private void DecodeAllow(string value)
	{
		string[] array = value.Split( new char[] { ',' } , StringSplitOptions.None);
		foreach (string item in array)
		{
			base.Headers.Allow.Add(item);
		}
	}

	private void DecodeExpires(string value)
	{
		base.Headers.Expires = DateTimeOffset.Parse(value);
	}

	private void DecodeLastModified(string value)
	{
		base.Headers.LastModified = DateTimeOffset.Parse(value);
	}
}
