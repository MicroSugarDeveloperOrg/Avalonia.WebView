namespace AVFoundation;

public struct AVCaptureWhiteBalanceChromaticityValues
{
	public float X;

	public float Y;

	public AVCaptureWhiteBalanceChromaticityValues(float x, float y)
	{
		X = x;
		Y = y;
	}

	public override string ToString()
	{
		return $"({X},{Y})";
	}

	public static bool operator ==(AVCaptureWhiteBalanceChromaticityValues left, AVCaptureWhiteBalanceChromaticityValues right)
	{
		return left.X == right.X && left.Y == right.Y;
	}

	public static bool operator !=(AVCaptureWhiteBalanceChromaticityValues left, AVCaptureWhiteBalanceChromaticityValues right)
	{
		return left.X != right.X || left.Y != right.Y;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is AVCaptureWhiteBalanceChromaticityValues))
		{
			return false;
		}
		return Equals((AVCaptureWhiteBalanceChromaticityValues)obj);
	}

	public bool Equals(AVCaptureWhiteBalanceChromaticityValues other)
	{
		return this == other;
	}

	public override int GetHashCode()
	{
		return X.GetHashCode() ^ Y.GetHashCode();
	}
}
