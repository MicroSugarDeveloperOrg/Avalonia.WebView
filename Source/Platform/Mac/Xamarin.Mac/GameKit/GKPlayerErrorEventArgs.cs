using System;
using Foundation;

namespace GameKit;

public class GKPlayerErrorEventArgs : EventArgs
{
	public NSError Error { get; set; }

	public string PlayerId { get; set; }

	public GKPlayerErrorEventArgs(string playerId, NSError error)
	{
		Error = error;
		PlayerId = playerId;
	}
}
