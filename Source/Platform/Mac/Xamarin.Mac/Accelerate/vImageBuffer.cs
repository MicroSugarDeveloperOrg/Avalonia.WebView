using System;

namespace Accelerate;

public struct vImageBuffer
{
	private nint HeightIntPtr;

	private nint WidthIntPtr;

	private nint RowBytesCountIntPtr;

	public IntPtr Data { get; set; }

	public int BytesPerRow
	{
		get
		{
			return (int)RowBytesCountIntPtr;
		}
		set
		{
			RowBytesCountIntPtr = value;
		}
	}

	public int Width
	{
		get
		{
			return (int)WidthIntPtr;
		}
		set
		{
			WidthIntPtr = value;
		}
	}

	public int Height
	{
		get
		{
			return (int)HeightIntPtr;
		}
		set
		{
			HeightIntPtr = value;
		}
	}
}
