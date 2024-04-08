namespace dcttest;
using dctstorefile;
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldCanRegisterTheDirPathAndSourcePath()
    {
           DctStoreFile dct = new("halo","hola");
           Console.WriteLine(dct.CheckInfo());
    }
}