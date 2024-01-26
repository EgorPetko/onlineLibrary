using onlineLibrary.Context.ContextManagement;

namespace onlineLibrary.Context.FileManagement
{
    public interface IFileManager
    {
        public string Path { get; set; }
        public string? AdditionalPath { get; set; }

        public void addFile(IFormFile uploadedFile,IManagerInContext managerInContext);

        public void removeFile(string fileName, IManagerInContext managerInContext);

        public void updateFile(IFormFile uploadedFile, IManagerInContext managerInContext);
    }
}
