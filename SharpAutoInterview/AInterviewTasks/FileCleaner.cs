namespace DirTasks;

public class FileCleaner
{
    public void CleanFilesInSubDirectories(string directoryPath)
    {
        DirectoryInfo directory = new DirectoryInfo(directoryPath);

        if(directory.Exists)
        {
            DirectoryInfo[] directories = directory.GetDirectories();

            foreach (var dir in directories)
            {
                CleanFilesInSubDirectories(dir.FullName);

                FileInfo[] files = dir.GetFiles();

                if (files.Length > 0)
                {
                    foreach (var fileInfo in files)
                    {
                        File.Delete(fileInfo.FullName);
                    }
                }

            }
        }
    }
}