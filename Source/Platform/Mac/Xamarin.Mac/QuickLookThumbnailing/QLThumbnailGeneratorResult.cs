namespace QuickLookThumbnailing;

public class QLThumbnailGeneratorResult
{
	public QLThumbnailRepresentation Arg1 { get; set; }

	public QLThumbnailRepresentationType Arg2 { get; set; }

	public QLThumbnailGeneratorResult(QLThumbnailRepresentation arg1, QLThumbnailRepresentationType arg2)
	{
		Arg1 = arg1;
		Arg2 = arg2;
	}
}
