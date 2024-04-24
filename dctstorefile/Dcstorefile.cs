using System.Diagnostics;
using System.Dynamic;
using System.IO;
namespace dctstorefile{
    public class DctStoreFile
    {   
        // private string? _fileName;
        private string? _dirPath;
        private string? _srcPath;
        private string? _fileName;
        
        
        public bool SetFileName(string fileName){
            if(fileName !=null){
                this._fileName = fileName;
                return true;
            }
            return false;

        }
        public bool CreateDirectory(){
            try
            {
                // Check if the directory exists
                if (!Directory.Exists(_dirPath))
                {
                    // If not, create the directory
                    Directory.CreateDirectory(_dirPath!);
                    Console.WriteLine("Directory created successfully.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Directory already exists.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            throw new Exception("Error during create new directory!");
        }
        public bool StoreFile(){
            string fileName = Path.GetFileName(_srcPath!);
            string destFilePath = Path.Combine(_dirPath!,fileName);
            string newFileName = Path.Combine(_dirPath!,_fileName!);
            try{
                if(!File.Exists(destFilePath)){
                    File.Move(_srcPath!, destFilePath);
                        if (File.Exists(destFilePath))
                        {
                            File.Move(destFilePath, newFileName);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                }
                else{
                    return false;
                }
            }
            catch{
                throw;
            }
        }
        public string CheckInfo(){
            if(_dirPath !=null && _srcPath!=null){
                return "dir path :"+_dirPath + "\n source path :"+_srcPath;
            }
            throw new Exception("dir path and source path not defined!!");
        }
        public bool SetDirPath(string dirPath){
            if(dirPath != null){
                this._dirPath = dirPath;
                return true;
            }
            return false;
        }
        public bool SetSrcPath(string srcPath){
            if(srcPath != null){
                this._srcPath = srcPath;
                return true;
            }
            return false;
        }
        public string GetDirPath(){
            if(_dirPath != null){
                return _dirPath;
            }
            throw new Exception("dir path not defined ");
        }
        public string GetSrcPath(){
            if(_srcPath != null){
                return _srcPath;
            }
            throw new Exception("src path not defined");
        }
        public async Task<string> GenerateFileName(string fileName){
            await Task.Delay(100);
            try{
                if(fileName!=null){
                    string uiidName = $"{Guid.NewGuid().ToString()}-{DateTime.Now.ToString("yyyyMMddHHmmss")}-{fileName}";
                    return uiidName;
                }
            }
            catch{
                throw;
            }
            throw new Exception("File to generate UIID Name ");
        }

    }
}
