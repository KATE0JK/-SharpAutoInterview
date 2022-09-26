namespace DirTasks;

public class FileAndDirCleaner
{
    public void CleanFiles(string directoryPath)
    {
        DirectoryInfo directory = new DirectoryInfo(directoryPath);

        FileInfo[] files = directory.GetFiles();

        if (files.Length > 0)
        {
            foreach (var fileInfo in files)
            {
                File.Delete(fileInfo.FullName);
            }
        }
        
        CleanDirectoriess(directoryPath);
    }
    
    private void CleanDirectoriess(string directoryPath)
    {
        DirectoryInfo directory = new DirectoryInfo(directoryPath);

        if(directory.Exists)
        {
            DirectoryInfo[] directories = directory.GetDirectories();

            foreach (var dir in directories)
            {
                CleanDirectoriess(dir.FullName);

                FileInfo[] files = dir.GetFiles();

                if (files.Length == 0)
                {
                    Directory.Delete(dir.FullName);
                }

            }
        }
    }
}