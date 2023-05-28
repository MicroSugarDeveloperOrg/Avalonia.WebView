namespace Foundation;

public class NSFileSystemAttributes
{
	private NSDictionary dict;

	public ulong Size { get; internal set; }

	public ulong FreeSize { get; internal set; }

	public long Nodes { get; internal set; }

	public long FreeNodes { get; internal set; }

	public uint Number { get; internal set; }

	internal NSFileSystemAttributes(NSDictionary dict)
	{
		this.dict = dict;
	}

	internal static NSFileSystemAttributes FromDictionary(NSDictionary dict)
	{
		if (dict == null)
		{
			return null;
		}
		NSFileSystemAttributes nSFileSystemAttributes = new NSFileSystemAttributes(dict);
		nSFileSystemAttributes.Size = NSFileAttributes.fetch_ulong(dict, NSFileManager.SystemSize).GetValueOrDefault();
		nSFileSystemAttributes.FreeSize = NSFileAttributes.fetch_ulong(dict, NSFileManager.SystemFreeSize).GetValueOrDefault();
		nSFileSystemAttributes.Nodes = NSFileAttributes.fetch_long(dict, NSFileManager.SystemNodes).GetValueOrDefault();
		nSFileSystemAttributes.FreeNodes = NSFileAttributes.fetch_long(dict, NSFileManager.SystemFreeNodes).GetValueOrDefault();
		nSFileSystemAttributes.Number = NSFileAttributes.fetch_uint(dict, NSFileManager.SystemFreeNodes).GetValueOrDefault();
		return nSFileSystemAttributes;
	}

	public static implicit operator NSDictionary(NSFileSystemAttributes attr)
	{
		return attr.dict;
	}
}
