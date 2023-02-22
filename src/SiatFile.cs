using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;
using System.IO.Compression;

namespace Markind.Siat;

public class SiatFile<T>
{
    public SiatFile(T @object)
    {
        using var inMemory = new MemoryStream();
        new XmlSerializer(typeof(T)).Serialize(inMemory, @object);
        inMemory.Position = 0;

        var outMemory = CompressGzip(inMemory);

        Bytes = outMemory.ToArray();
        Hash = CalculateHash(new MemoryStream(Bytes));
    }
    public string Hash { get; }
    public byte[] Bytes { get; }

    public MemoryStream CompressGzip(MemoryStream inputStream)
    {
        inputStream.Position = 0;

        var outStream = new MemoryStream((int)(inputStream.Length / 2)); //set to estimate of compression ratio
        using var gzipStream = new GZipStream(outStream, CompressionMode.Compress);

        inputStream.CopyTo(gzipStream);

        return outStream;
    }

    private static string CalculateHash(MemoryStream stream)
    {
        stream.Position = 0;

        var hash = new StringBuilder();
        using var sha = SHA256.Create();
        foreach (byte x in sha.ComputeHash(stream)) hash.AppendFormat("{0:x2}", x);

        return hash.ToString();
    }
}