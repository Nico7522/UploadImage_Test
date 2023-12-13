namespace UploadImage_Test.Models
{
    public class FileModel
    {
        public string Directory { get;  }
        public IFormFile File { get; set; }
        public FileModel()
        {
            Directory = "K:\\Visual Studio installation\\Projets\\UploadImage_Test\\UploadImage_Test\\wwwroot\\images";
        }

    }
}
