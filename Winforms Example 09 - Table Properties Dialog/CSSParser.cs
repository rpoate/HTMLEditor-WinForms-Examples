using System;
using System.Collections.Generic;
using System.Text;

internal sealed class InlineCssParser
{
    public InlineCssParser(string rawInlineCss)
    {
        InlineCss = rawInlineCss ?? string.Empty;
    }

    public string InlineCss { get; set; }

    public void SetValue(string name, string value)
    {
        var dic = parse(InlineCss);
        setDictionary(dic, name, value);
        InlineCss = combine(dic);
    }

    public string GetValue(string name)
    {
        return getDictionary(parse(InlineCss), name);
    }

    public void RemoveItem(string name)
    {
        var dic = parse(InlineCss);
        removeFromDictionary(dic, name);
        InlineCss = combine(dic);
    }

    public bool HasName(string name)
    {
        return hasDictionary(parse(InlineCss), name);
    }

    private static string combine(ICollection<KeyValuePair<string, string>> dic)
    {
        if (dic == null || dic.Count <= 0)
            return string.Empty;
        else
        {
            var result = new StringBuilder();

            foreach (KeyValuePair<string, string> pair in dic)
            {
                if (result.Length > 0)
                    result.Append("; ");
                result.AppendFormat("{0}: {1}", pair.Key, pair.Value);
            }

            return result.ToString();
        }
    }

    private static Dictionary<string, string> parse(string raw)
    {
        var result = new Dictionary<string, string>();

        if (raw != null)
        {
            var firsts = raw.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string first in firsts)
            {
                var f = first.Trim();

                if (!string.IsNullOrEmpty(f))
                {
                    var seconds = f.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                    if (seconds.Length == 2)
                    {
                        var a = seconds[0].Trim().ToLowerInvariant();
                        var b = seconds[1].Trim();

                        if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b))
                        {
                            if (a != "border")
                                setDictionary(result, a, b);
                            else
                            {
                                var borders = b.Split(new[] { ' ' }, 3, StringSplitOptions.RemoveEmptyEntries);
                                setDictionary(result, "border-width", borders[0]);
                                setDictionary(result, "border-style", borders[1]);
                                setDictionary(result, "border-color", borders[2]);
                            }
                        }
                    }
                }
            }
        }

        return result;
    }

    private static string getDictionary(IDictionary<string, string> dic, string a)
    {
        return dic.ContainsKey(a.ToLowerInvariant()) ? dic[a.ToLowerInvariant()] : null;
    }

    private static bool hasDictionary(IDictionary<string, string> dic, string a)
    {
        return dic.ContainsKey(a.ToLowerInvariant());
    }

    private static void removeFromDictionary(IDictionary<string, string> dic, string a)
    {
        if (dic.ContainsKey(a.ToLowerInvariant()))
            dic.Remove(a.ToLowerInvariant());
    }

    private static void setDictionary(IDictionary<string, string> dic, string a, string b)
    {
        if (dic.ContainsKey(a.ToLowerInvariant()))
            dic[a.ToLowerInvariant()] = b;
        else
            dic.Add(a.ToLowerInvariant(), b);
    }
}
