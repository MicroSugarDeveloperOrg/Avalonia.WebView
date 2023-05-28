using AppKit;

namespace GameKit;

public class GKChallengeComposeResult
{
	public NSViewController ComposeController { get; set; }

	public bool IssuedChallenge { get; set; }

	public string[] SentPlayerIDs { get; set; }

	public GKChallengeComposeResult(NSViewController composeController, bool issuedChallenge, string[] sentPlayerIDs)
	{
		ComposeController = composeController;
		IssuedChallenge = issuedChallenge;
		SentPlayerIDs = sentPlayerIDs;
	}
}
