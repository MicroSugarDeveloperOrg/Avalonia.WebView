using System;
using Foundation;

namespace AppKit;

public class NSDictionaryEventArgs : EventArgs
{
	public NSDictionary UserInfo { get; set; }

	public NSDictionaryEventArgs(NSDictionary userInfo)
	{
		UserInfo = userInfo;
	}
}
