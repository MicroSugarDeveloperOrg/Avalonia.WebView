namespace Foundation;

public class NSUrlSessionActiveTasks
{
	public NSUrlSessionDataTask[] DataTasks { get; set; }

	public NSUrlSessionUploadTask[] UploadTasks { get; set; }

	public NSUrlSessionDownloadTask[] DownloadTasks { get; set; }

	public NSUrlSessionActiveTasks(NSUrlSessionDataTask[] dataTasks, NSUrlSessionUploadTask[] uploadTasks, NSUrlSessionDownloadTask[] downloadTasks)
	{
		DataTasks = dataTasks;
		UploadTasks = uploadTasks;
		DownloadTasks = downloadTasks;
	}
}
