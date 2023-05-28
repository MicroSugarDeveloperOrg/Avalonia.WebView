using System;
using CloudKit;

namespace AppKit;

public class NSApplicationUserAcceptedCloudKitShareEventArgs : EventArgs
{
	public CKShareMetadata Metadata { get; set; }

	public NSApplicationUserAcceptedCloudKitShareEventArgs(CKShareMetadata metadata)
	{
		Metadata = metadata;
	}
}
