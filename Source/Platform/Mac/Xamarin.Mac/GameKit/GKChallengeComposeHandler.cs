using AppKit;

namespace GameKit;

public delegate void GKChallengeComposeHandler(NSViewController composeController, bool issuedChallenge, string[] sentPlayerIDs);
