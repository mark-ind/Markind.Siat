using System.Text.Json;

namespace Markind.Siat.Utils;

public static class ObjectExtensions
{
    /// <summary>
    /// The string representation of null.
    /// </summary>
    private static readonly string Null = "null";

    /// <summary>
    /// To json.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The Json of any object.</returns>
    public static string ToJson(this object value, bool ignoreNullValues = true)
    {
        if(value == null) return Null;
#pragma warning disable CS0618, SYSLIB0020 // Type or member is obsolete
        return JsonSerializer.Serialize(value, options: new JsonSerializerOptions() { WriteIndented = true, IgnoreNullValues = ignoreNullValues });
#pragma warning restore CS0618, SYSLIB0020 // Type or member is obsolete

    }

    public static void Dump(this object value)
    {
        Console.WriteLine(value.ToJson());
    }
}