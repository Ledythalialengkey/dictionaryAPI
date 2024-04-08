using System.Diagnostics;
using System.IO;
namespace dctstorefile{
    public class DctStoreFile
    {   
        // private string? _fileName;
        private string _dirPath;
        private string _sourcePath;
        
        public DctStoreFile(string destPath, string sourcePath){
            _dirPath = destPath;
            _sourcePath = sourcePath;
        }
        public void CreateDirectory(){
            try
            {
                // Check if the directory exists
                if (!Directory.Exists(_dirPath))
                {
                    // If not, create the directory
                    Directory.CreateDirectory(_dirPath);
                    Console.WriteLine("Directory created successfully.");
                }
                else
                {
                    Console.WriteLine("Directory already exists.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        public void StoreFile(){
            try{
                File.Move(_sourcePath,_dirPath);
            }
            catch(Exception e){
                Console.WriteLine(e);
            }
        }
        public string CheckInfo(){
            if(_dirPath !=null && _sourcePath!=null){
                return "dir path :"+_dirPath + "\n source path :"+_sourcePath;
            }
            throw new Exception("Dir path and source path not defined!!");
        }
    }
}
