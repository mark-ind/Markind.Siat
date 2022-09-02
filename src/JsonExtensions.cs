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
    public static string ToJson(this object value)
    {
        if (value == null) return Null;

        return JsonSerializer.Serialize(value, options: new JsonSerializerOptions(){WriteIndented = true});
    }
}