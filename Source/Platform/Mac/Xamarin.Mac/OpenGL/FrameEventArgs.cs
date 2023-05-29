using System;

namespace OpenGL;

public class FrameEventArgs : EventArgs
{
	private double elapsed;

	public double Time
	{
		get
		{
			return elapsed;
		}
		internal set
		{
			if (value < 0.0)
			{
				throw new ArgumentOutOfRangeException();
			}
			elapsed = value;
		}
	}

	public FrameEventArgs()
	{
	}

	public FrameEventArgs(double elapsed)
	{
		Time = elapsed;
	}
}
