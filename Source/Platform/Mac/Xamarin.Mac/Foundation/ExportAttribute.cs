using System;
using System.Reflection;
using ObjCRuntime;

namespace Foundation;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
public class ExportAttribute : Attribute
{
	private string selector;

	private ArgumentSemantic semantic;

	public string Selector
	{
		get
		{
			return selector;
		}
		set
		{
			selector = value;
		}
	}

	public ArgumentSemantic ArgumentSemantic
	{
		get
		{
			return semantic;
		}
		set
		{
			semantic = value;
		}
	}

	public bool IsVariadic { get; set; }

	public ExportAttribute()
	{
	}

	public ExportAttribute(string selector)
	{
		this.selector = selector;
		semantic = ArgumentSemantic.None;
	}

	public ExportAttribute(string selector, ArgumentSemantic semantic)
	{
		this.selector = selector;
		this.semantic = semantic;
	}

	public ExportAttribute ToGetter(PropertyInfo prop)
	{
		if (string.IsNullOrEmpty(Selector))
		{
			Selector = prop.Name;
		}
		return new ExportAttribute(selector, semantic);
	}

	public ExportAttribute ToSetter(PropertyInfo prop)
	{
		if (string.IsNullOrEmpty(Selector))
		{
			Selector = prop.Name;
		}
		return new ExportAttribute($"set{char.ToUpperInvariant(selector[0])}{selector.Substring(1)}:", semantic);
	}
}
