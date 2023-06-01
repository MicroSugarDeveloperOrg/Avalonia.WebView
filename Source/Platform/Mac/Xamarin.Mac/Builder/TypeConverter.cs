using ObjCRuntime;
using System.Reflection;
using System.Text;
using Xamarin.System;

namespace Builder;

public static class TypeConverter
{
    public static Type ToManaged(string type)
    {
        switch (type[0])
        {
            case '@':
                return typeof(IntPtr);
            case '#':
                return typeof(IntPtr);
            case ':':
                return typeof(IntPtr);
            case 'c':
                return typeof(char);
            case 'C':
                return typeof(char);
            case 's':
                return typeof(short);
            case 'S':
                return typeof(ushort);
            case 'i':
            case 'l':
                return typeof(int);
            case 'I':
            case 'L':
                return typeof(uint);
            case 'q':
                return typeof(long);
            case 'Q':
                return typeof(ulong);
            case 'f':
                return typeof(float);
            case 'd':
                return typeof(double);
            case 'b':
                return typeof(char);
            case 'B':
                return typeof(bool);
            case 'v':
                return typeof(void);
            case '?':
                return typeof(IntPtr);
            case '^':
                return typeof(IntPtr);
            case '*':
                return typeof(string);
            case '%':
                return typeof(IntPtr);
            case '[':
                throw new NotImplementedException("arrays");
            case '(':
                throw new NotImplementedException("unions");
            case '{':
                {
                    string text = type.Substring(1, type.IndexOf('=') - 1);
                    foreach (Assembly assembly in Runtime.GetAssemblies())
                    {
                        Type[] types = assembly.GetTypes();
                        foreach (Type type2 in types)
                        {
                            if (type2.IsValueType && !type2.IsEnum && type2.Name == text)
                                return type2;
                        }
                    }
                    throw new NotImplementedException("struct marshalling: " + text + " " + type);
                }
            case '!':
                throw new NotImplementedException("vectors");
            case 'r':
                throw new NotImplementedException("consts");
            default:
                throw new Exception("Teach me how to parse: " + type);
        }
    }

    public static string ToNative(Type type)
    {
        if (type.IsGenericParameter)
            throw new ArgumentException("Unable to convert generic types");

        if (type.IsByRef)
            return "^" + ToNative(type.GetElementType());

        if (type == typeof(IntPtr))
        {
            return "^v";
        }
        if (type == typeof(byte))
        {
            return "c";
        }
        if (type == typeof(sbyte))
        {
            return "c";
        }
        if (type == typeof(char))
        {
            return "c";
        }
        if (type == typeof(short))
        {
            return "s";
        }
        if (type == typeof(ushort))
        {
            return "S";
        }
        if (type == typeof(int))
        {
            return "i";
        }
        if (type == typeof(uint))
        {
            return "I";
        }
        if (type == typeof(long))
        {
            return "q";
        }
        if (type == typeof(ulong))
        {
            return "Q";
        }
        if (type == typeof(float))
        {
            return "f";
        }
        if (type == typeof(double))
        {
            return "d";
        }
        if (type == typeof(bool))
        {
            return "B";
        }
        if (type == typeof(void))
        {
            return "v";
        }
        if (type == typeof(string))
        {
            return "@";
        }
        if (type == typeof(Selector))
        {
            return ":";
        }
        if (type == typeof(Class))
        {
            return "#";
        }
        if (type == typeof(nfloat))
        {
            if (IntPtr.Size != 8)
                return "f";
            return "d";
        }
        if (type == typeof(IntPtr))
        {
            if (IntPtr.Size != 8)
            {
                return "i";
            }
            return "q";
        }
        if (type == typeof(UIntPtr))
        {
            if (IntPtr.Size != 8)
            {
                return "I";
            }
            return "Q";
        }
        if (typeof(INativeObject).IsAssignableFrom(type))
        {
            return "@";
        }
        if (type.IsValueType && !type.IsEnum)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("{{{0}=", type.Name);
            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (FieldInfo fieldInfo in fields)
                stringBuilder.Append(ToNative(fieldInfo.FieldType));
            stringBuilder.Append("}");
            return stringBuilder.ToString();
        }

        if (type.IsValueType && type.IsEnum)
            return ToNative(Enum.GetUnderlyingType(type));

        if (type.IsArray)
            return "@";

        if (type.IsSubclassOf(typeof(Delegate)))
            return "^v";

        throw new NotImplementedException("Don't know how to marshal: " + type.ToString());
    }
}
