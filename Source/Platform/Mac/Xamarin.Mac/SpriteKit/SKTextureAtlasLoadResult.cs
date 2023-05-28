using Foundation;

namespace SpriteKit;

public class SKTextureAtlasLoadResult
{
	public NSError Error { get; set; }

	public SKTextureAtlas FoundAtlases { get; set; }

	public SKTextureAtlasLoadResult(NSError error, SKTextureAtlas foundAtlases)
	{
		Error = error;
		FoundAtlases = foundAtlases;
	}
}
