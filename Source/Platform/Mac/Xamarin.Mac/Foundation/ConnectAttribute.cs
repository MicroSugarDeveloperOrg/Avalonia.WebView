using System;

namespace Foundation;

[AttributeUsage(AttributeTargets.Property)]
public sealed class ConnectAttribute : Attribute
{
	private string name;

	public string Name
	{
		get
		{
			return name;
		}
		set
		{
			name = value;
		}
	}

	public ConnectAttribute()
	{
	}

	public ConnectAttribute(string name)
	{
		this.name = name;
	}
}
