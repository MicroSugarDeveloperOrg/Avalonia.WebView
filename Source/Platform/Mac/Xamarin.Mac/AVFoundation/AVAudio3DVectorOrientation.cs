using OpenTK;

namespace AVFoundation;

public struct AVAudio3DVectorOrientation
{
	public Vector3 Forward;

	public Vector3 Up;

	public AVAudio3DVectorOrientation(Vector3 forward, Vector3 up)
	{
		Forward = forward;
		Up = up;
	}

	public override string ToString()
	{
		return $"({Forward}:{Up})";
	}

	public static bool operator ==(AVAudio3DVectorOrientation left, AVAudio3DVectorOrientation right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(AVAudio3DVectorOrientation left, AVAudio3DVectorOrientation right)
	{
		return !left.Equals(right);
	}

	public override bool Equals(object obj)
	{
		if (!(obj is AVAudio3DVectorOrientation))
		{
			return false;
		}
		return Equals((AVAudio3DVectorOrientation)obj);
	}

	public bool Equals(AVAudio3DVectorOrientation other)
	{
		return Forward == other.Forward && Up == other.Up;
	}

	public override int GetHashCode()
	{
		return Forward.GetHashCode() ^ Up.GetHashCode();
	}
}
