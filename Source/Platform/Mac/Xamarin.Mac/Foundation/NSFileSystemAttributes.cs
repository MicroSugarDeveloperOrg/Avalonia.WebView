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

	internal static NSFileSystemAttributes FromDict(NSDictionary dict)
	{
		if (dict == null)
		{
			return null;
		}
		NSFileSystemAttributes nSFileSystemAttributes = new NSFileSystemAttributes(dict);
		ulong b = 0uL;
		uint b2 = 0u;
		nSFileSystemAttributes.Size = (NSFileAttributes.fetch(dict, NSFileManager.SystemSize, ref b) ? b : 0);
		nSFileSystemAttributes.FreeSize = (NSFileAttributes.fetch(dict, NSFileManager.SystemFreeSize, ref b) ? b : 0);
		nSFileSystemAttributes.Nodes = (long)(NSFileAttributes.fetch(dict, NSFileManager.SystemNodes, ref b) ? b : 0);
		nSFileSystemAttributes.FreeNodes = (long)(NSFileAttributes.fetch(dict, NSFileManager.SystemFreeNodes, ref b) ? b : 0);
		nSFileSystemAttributes.Number = (NSFileAttributes.fetch(dict, NSFileManager.SystemFreeNodes, ref b2) ? b2 : 0u);
		return nSFileSystemAttributes;
	}

	public static implicit operator NSDictionary(NSFileSystemAttributes attr)
	{
		return attr.dict;
	}
}
