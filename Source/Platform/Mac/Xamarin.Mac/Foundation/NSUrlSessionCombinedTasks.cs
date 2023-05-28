namespace Foundation;

public class NSUrlSessionCombinedTasks
{
	public NSUrlSessionTask[] Tasks { get; set; }

	public NSUrlSessionCombinedTasks(NSUrlSessionTask[] tasks)
	{
		Tasks = tasks;
	}
}
