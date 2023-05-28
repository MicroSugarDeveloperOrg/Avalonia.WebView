namespace GameKit;

public class GKCategoryResult
{
	public string[] Categories { get; set; }

	public string[] Titles { get; set; }

	public GKCategoryResult(string[] categories, string[] titles)
	{
		Categories = categories;
		Titles = titles;
	}
}
