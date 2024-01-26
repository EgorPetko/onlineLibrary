using Microsoft.EntityFrameworkCore;
using onlineLibrary.Context.ContextManagement;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace onlineLibrary.Context.FileManagement
{
    public class LocalFileManager : IFileManager
    {
        public string Path { get; set; }
        public string? AdditionalPath { get; set; }

        public LocalFileManager(string? additionalPath = null ,string? path = null) {
            AdditionalPath = additionalPath;
            if (path == null)
            {
                path = "D:\\Projects\\onlineLibrary\\onlineLibrary\\Files"; //изменить и добавить в конфигурацию
            }

            Path = path;
        }

        public void addFile(IFormFile uploadedFile, IManagerInContext managerInContext)
        {
            if (uploadedFile == null) return;

            string path = getFullPath(uploadedFile.FileName);

            // сохраняем файл 
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                uploadedFile.CopyToAsync(fileStream); //???
            }

            managerInContext.add();
        }

        public void removeFile(string fileName, IManagerInContext managerInContext)
        {
            string path = getFullPath(fileName);

            if (File.Exists(path))
                File.Delete(path);

            managerInContext.remove();
        }

        public void updateFile(IFormFile uploadedFile, IManagerInContext managerInContext)
        {
            if (uploadedFile == null) return;

            string path = getFullPath(uploadedFile.FileName);

            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                uploadedFile.CopyToAsync(fileStream); //???
            }

            managerInContext.update();
        }
        
        private string getFullPath(string fileName)
        {
            string path = Path;
            if (AdditionalPath != null)
            {
                path += "\\" + AdditionalPath;
            }
            path += "\\" + fileName;
            return path;
        }
    }
}
