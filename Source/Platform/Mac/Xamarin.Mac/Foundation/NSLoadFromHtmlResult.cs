namespace Foundation;

public class NSLoadFromHtmlResult
{
	public NSAttributedString AttributedString { get; set; }

	public NSDictionary<NSString, NSObject> Attributes { get; set; }

	public NSLoadFromHtmlResult(NSAttributedString attributedString, NSDictionary<NSString, NSObject> attributes)
	{
		AttributedString = attributedString;
		Attributes = attributes;
	}
}
