namespace dcttest;
using dctstorefile;

public class Tests
{

    [SetUp]
    public void Setup(){
        DctStoreFile dct = new();
        dct.SetDirPath("./SrcPath");
        string dirPath = dct.GetDirPath();
        dct.CreateDirectory();
        string mockFilePath = dirPath + "/mockFile.mp4";
        
        if (!File.Exists(mockFilePath))
        {
            // If the file does not exist, create it
            using (File.Create(mockFilePath)) // Create the file and automatically close it when done
            {
                Console.WriteLine("File created successfully.");
            }
        }
        else
        {
            Console.WriteLine("File already exists.");
        }
        
    }
    [Test]
    public void ShouldCanRegisterTheDirPathAndSourcePath()
    {
        string expectedDirPath = "C:/Windows/System32/dirfile/cmd.exe";
        string expectedSrcPath = "C:/Windows/System32/srcfile/cmd.exe";
        DctStoreFile dct = new();
        dct.SetDirPath(expectedDirPath);
        dct.SetSrcPath(expectedSrcPath);
            
        string actualDirPath = dct.GetDirPath();
        string actualSrcPath = dct.GetSrcPath();
        Console.WriteLine(dct.CheckInfo());
        Assert.That(actualDirPath,Is.EqualTo(expectedDirPath));
        Assert.That(actualSrcPath,Is.EqualTo(expectedSrcPath));
    }
    [Test]
    public void ShouldReturnTrueIfDirectoryCreatedSuccessfully(){
        DctStoreFile dct = new();
        dct.SetDirPath("./CreatedDir");
        dct.SetSrcPath("");
        bool directoryCreated = dct.CreateDirectory();
        Assert.True(directoryCreated);
    }

    [Test]
    public void ShouldReturnExceptionIfFailToCreatedDir(){
        DctStoreFile dct = new();
        dct.SetDirPath(">>CreatedFile");
        dct.SetSrcPath("");
        Assert.Throws<Exception>(()=>{
            dct.CreateDirectory();
        });
    }
    [Test]
    public void ShouldBeAbleToStoreNewFile(){
        DctStoreFile dct = new();
        dct.SetDirPath("./CreatedDir");
        dct.SetSrcPath("./SrcPath/mockFile.mp4");
        dct.SetFileName("afaw1casdfasdmfkiad.mp4");
        bool result = dct.StoreFile();
        Assert.True(result);
    }
    [Test]
    public async Task ShouldBeAbleToGenerateTheUiidFileName(){
        DctStoreFile dct = new();
        dct.SetDirPath("./CreatedDir");
        dct.SetSrcPath("./SrcPath/mockFile.mp4");
        string output = await dct.GenerateFileName("test4");
        Console.WriteLine(output);
        Assert.NotNull(output);
    }
}