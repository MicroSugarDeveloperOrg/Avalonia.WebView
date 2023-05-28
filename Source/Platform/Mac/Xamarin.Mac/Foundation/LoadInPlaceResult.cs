namespace Foundation;

public class LoadInPlaceResult
{
	public NSUrl FileUrl { get; set; }

	public bool IsInPlace { get; set; }

	public LoadInPlaceResult(NSUrl fileUrl, bool isInPlace)
	{
		FileUrl = fileUrl;
		IsInPlace = isInPlace;
	}
}
