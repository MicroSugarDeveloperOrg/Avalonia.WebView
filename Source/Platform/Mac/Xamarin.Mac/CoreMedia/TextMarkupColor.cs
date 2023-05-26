using System;

namespace CoreMedia;

public struct TextMarkupColor
{
	public float Red { get; private set; }

	public float Green { get; private set; }

	public float Blue { get; private set; }

	public float Alpha { get; private set; }

	public TextMarkupColor(float red, float green, float blue, float alpha)
	{
		this = default(TextMarkupColor);
		if (red < 0f || (double)red > 1.0)
		{
			throw new ArgumentOutOfRangeException("red");
		}
		if (green < 0f || (double)green > 1.0)
		{
			throw new ArgumentOutOfRangeException("green");
		}
		if (blue < 0f || (double)blue > 1.0)
		{
			throw new ArgumentOutOfRangeException("blue");
		}
		if (alpha < 0f || (double)alpha > 1.0)
		{
			throw new ArgumentOutOfRangeException("alpha");
		}
		Red = red;
		Green = green;
		Blue = blue;
		Alpha = alpha;
	}
}
