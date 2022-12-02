// The Strategy declares an interface that is common to all supported algorithms. The Context object uses
// this interface to call the algorithm defined by a ConcreteStrategy
public interface ICompression
{
    void CompressFolder(string compressedArchiveFileName);
}

// Each concrete strategy by which we will compress a file item
// must be implementing the method CompressFolder of ICompression interface.
// Let’s create two concrete strategy classes as per our business requirement.

public class RarCompression : ICompression
{
    public void CompressFolder(string compressedArchiveFileName)
    {
        Console.WriteLine("Folder is compressed using Rar approach: '" + compressedArchiveFileName
             + ".rar' file is created");
    }
}


public class ZipCompression : ICompression
{
    public void CompressFolder(string compressedArchiveFileName)
    {
        Console.WriteLine("Folder is compressed using zip approach: '" + compressedArchiveFileName
             + ".zip' file is created");
    }
}

//  This context class contains a property that is used to hold the reference of a Strategy object.
//  This property will be set at run-time by the client according to the algorithm that is required.
public class CompressionContext
{
    private ICompression Compression;

    public CompressionContext(ICompression Compression)
    {
        this.Compression = Compression;
    }
    public void SetStrategy(ICompression Compression)
    {
        this.Compression = Compression;
    }
    public void CreateArchive(string compressedArchiveFileName)
    {
        Compression.CompressFolder(compressedArchiveFileName);
    }
}

class Program
{
    static void Main(string[] args)
    {
        CompressionContext ctx = new CompressionContext(new ZipCompression());
        ctx.CreateArchive("DotNetDesignPattern");
        ctx.SetStrategy(new RarCompression());
        ctx.CreateArchive("DotNetDesignPattern");
        Console.Read();
    }
}