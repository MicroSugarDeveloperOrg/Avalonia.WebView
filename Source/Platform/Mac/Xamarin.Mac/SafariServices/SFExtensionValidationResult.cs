using Foundation;

namespace SafariServices;

public class SFExtensionValidationResult
{
	public bool ShouldHide { get; set; }

	public NSString Text { get; set; }

	public SFExtensionValidationResult(bool shouldHide, NSString text)
	{
		ShouldHide = shouldHide;
		Text = text;
	}
}
