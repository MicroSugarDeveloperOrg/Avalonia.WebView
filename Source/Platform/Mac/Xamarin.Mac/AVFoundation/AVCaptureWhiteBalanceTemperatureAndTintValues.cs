namespace AVFoundation;

public struct AVCaptureWhiteBalanceTemperatureAndTintValues
{
	public float Temperature;

	public float Tint;

	public AVCaptureWhiteBalanceTemperatureAndTintValues(float temperature, float tint)
	{
		Temperature = temperature;
		Tint = tint;
	}

	public override string ToString()
	{
		return $"(Temperature={Temperature},Tint={Tint})";
	}

	public static bool operator ==(AVCaptureWhiteBalanceTemperatureAndTintValues left, AVCaptureWhiteBalanceTemperatureAndTintValues right)
	{
		return left.Temperature == right.Temperature && left.Tint == right.Tint;
	}

	public static bool operator !=(AVCaptureWhiteBalanceTemperatureAndTintValues left, AVCaptureWhiteBalanceTemperatureAndTintValues right)
	{
		return left.Temperature != right.Temperature || left.Tint != right.Tint;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is AVCaptureWhiteBalanceTemperatureAndTintValues))
		{
			return false;
		}
		return Equals((AVCaptureWhiteBalanceTemperatureAndTintValues)obj);
	}

	public bool Equals(AVCaptureWhiteBalanceTemperatureAndTintValues other)
	{
		return this == other;
	}

	public override int GetHashCode()
	{
		return Temperature.GetHashCode() ^ Tint.GetHashCode();
	}
}
