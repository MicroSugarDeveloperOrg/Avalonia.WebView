using System;

namespace Foundation;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public sealed class RegisterAttribute : Attribute
{
	private string name;

	private bool is_wrapper;

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

	public bool IsWrapper
	{
		get
		{
			return is_wrapper;
		}
		set
		{
			is_wrapper = value;
		}
	}

    public bool SkipRegistration { get; set; }


    public RegisterAttribute()
	{
	}

	public RegisterAttribute(string name)
	{
		this.name = name;
	}

	public RegisterAttribute(string name, bool isWrapper)
	{
		this.name = name;
		is_wrapper = isWrapper;
	}
}
