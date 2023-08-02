using System;

namespace AVFoundation;

public class AVCategoryEventArgs : EventArgs
{
	public string Category { get; private set; }

	public AVCategoryEventArgs(string category)
	{
		Category = category;
	}
}
