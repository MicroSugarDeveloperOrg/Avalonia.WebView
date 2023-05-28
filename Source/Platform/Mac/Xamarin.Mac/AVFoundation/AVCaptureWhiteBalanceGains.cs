namespace AVFoundation;

public struct AVCaptureWhiteBalanceGains
{
	public float RedGain;

	public float GreenGain;

	public float BlueGain;

	public AVCaptureWhiteBalanceGains(float redGain, float greenGain, float blueGain)
	{
		RedGain = redGain;
		GreenGain = greenGain;
		BlueGain = blueGain;
	}

	public override string ToString()
	{
		return $"(RedGain={RedGain},GreenGain={GreenGain},BlueGain={BlueGain})";
	}

	public static bool operator ==(AVCaptureWhiteBalanceGains left, AVCaptureWhiteBalanceGains right)
	{
		return left.RedGain == right.RedGain && left.GreenGain == right.GreenGain && left.BlueGain == right.BlueGain;
	}

	public static bool operator !=(AVCaptureWhiteBalanceGains left, AVCaptureWhiteBalanceGains right)
	{
		return left.RedGain != right.RedGain || left.GreenGain != right.GreenGain || left.BlueGain != right.BlueGain;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is AVCaptureWhiteBalanceGains))
		{
			return false;
		}
		return Equals((AVCaptureWhiteBalanceGains)obj);
	}

	public bool Equals(AVCaptureWhiteBalanceGains other)
	{
		return this == other;
	}

	public override int GetHashCode()
	{
		return RedGain.GetHashCode() ^ GreenGain.GetHashCode() ^ BlueGain.GetHashCode();
	}
}
