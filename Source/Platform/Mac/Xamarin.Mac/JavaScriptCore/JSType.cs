namespace JavaScriptCore;

public enum JSType
{
	Undefined,
	Null,
	Boolean,
	Number,
	String,
	Object,
	[iOS(13, 0)]
	[Mac(10, 15)]
	Symbol
}
