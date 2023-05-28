using System;
using Foundation;

namespace GameKit;

public class GKDataReceivedForRecipientEventArgs : EventArgs
{
	public NSData Data { get; set; }

	public GKPlayer Player { get; set; }

	public GKPlayer Recipient { get; set; }

	public GKDataReceivedForRecipientEventArgs(NSData data, GKPlayer recipient, GKPlayer player)
	{
		Data = data;
		Player = player;
		Recipient = recipient;
	}
}
