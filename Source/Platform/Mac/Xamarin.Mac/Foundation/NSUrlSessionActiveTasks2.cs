namespace Foundation;

public class NSUrlSessionActiveTasks2
{
	public NSUrlSessionTask[] DataTasks { get; set; }

	public NSUrlSessionTask[] UploadTasks { get; set; }

	public NSUrlSessionTask[] DownloadTasks { get; set; }

	public NSUrlSessionActiveTasks2(NSUrlSessionTask[] dataTasks, NSUrlSessionTask[] uploadTasks, NSUrlSessionTask[] downloadTasks)
	{
		DataTasks = dataTasks;
		UploadTasks = uploadTasks;
		DownloadTasks = downloadTasks;
	}
}
