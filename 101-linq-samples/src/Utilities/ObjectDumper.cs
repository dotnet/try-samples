using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

public class ObjectDumper
{
    public static void Write(object o) => Write(o, 0);

    public static void Write(object o, int depth)
    {
        var dumper = new ObjectDumper(depth);
        dumper.WriteObject(null, o);
    }

    TextWriter writer = Console.Out;
    int pos;
    int level;
    int depth;

    private ObjectDumper(int depth) => this.depth = depth;

    private void Write(string s)
    {
        writer.Write(s);
        pos += s?.Length ?? 0;
    }

    private void WriteIndent()
    {
        for (int i = 0; i < level; i++) writer.Write("  ");
    }

    private void WriteLine()
    {
        writer.WriteLine();
        pos = 0;
    }

    private void WriteTab()
    {
        do {
            Write("  ");
        }  while (pos % 8 != 0);
    }

    private void WriteObject(string prefix, object o)
    {
        switch (o)
        {
            case null:
            case ValueType v:
            case string s:
                WriteIndent();
                Write(prefix);
                WriteValue(o);
                WriteLine();
                break;
            case IEnumerable e:
                foreach (object element in e)
                {
                    if (element is IEnumerable && !(element is string))
                    {
                        WriteIndent();
                        Write(prefix);
                        Write("...");
                        WriteLine();
                        if (level < depth)
                        {
                            level++;
                            WriteObject(prefix, element);
                            level--;
                        }
                    }
                    else
                    {
                        WriteObject(prefix, element);
                    }
                }
                break;
            default:
                MemberInfo[] members = o.GetType().GetMembers(BindingFlags.Public | BindingFlags.Instance);
                WriteIndent();
                Write(prefix);
                bool propWritten = false;
                foreach (MemberInfo m in members)
                {
                    FieldInfo f = m as FieldInfo;
                    PropertyInfo p = m as PropertyInfo;
                    if (f != null || p != null)
                    {
                        if (propWritten)
                        {
                            WriteTab();
                        }
                        else
                        {
                            propWritten = true;
                        }
                        Write(m.Name);
                        Write("=");
                        Type t = f != null ? f.FieldType : p.PropertyType;
                        if (t.IsValueType || t == typeof(string))
                        {
                            WriteValue(f != null ? f.GetValue(o) : p.GetValue(o, null));
                        }
                        else
                        {
                            if (typeof(IEnumerable).IsAssignableFrom(t))
                            {
                                Write("...");
                            }
                            else
                            {
                                Write("{ }");
                            }
                        }
                    }
                }
                if (propWritten) WriteLine();
                if (level < depth)
                {
                    foreach (MemberInfo m in members)
                    {
                        FieldInfo f = m as FieldInfo;
                        PropertyInfo p = m as PropertyInfo;
                        if (f != null || p != null)
                        {
                            Type t = f != null ? f.FieldType : p.PropertyType;
                            if (!(t.IsValueType || t == typeof(string)))
                            {
                                object value = f != null ? f.GetValue(o) : p.GetValue(o, null);
                                if (value != null)
                                {
                                    level++;
                                    WriteObject(m.Name + ": ", value);
                                    level--;
                                }
                            }
                        }
                    }
                }
                break;
        }
    }

    private void WriteValue(object o)
    {
        switch (o)
        {
            case null:
                Write("null");
                break;
            case DateTime t:
                Write(t.ToShortDateString());
                break;
            default:
                Write(o.ToString());
                break;
        }
    }
}
