using System.Text;

namespace ReadFile;

public class ReadMultipleFiles
{
    //private string content = "";
    private StringBuilder contentBuilber = new StringBuilder();
    
    public void ReadFiles(params string[] pathNames)
    {
        foreach (var pathName in pathNames)
        {
            //content = content + File.ReadAllText(pathName);

            contentBuilber.Append(File.ReadAllText(pathName));
        }
    }

    private void WriteToFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            File.Create(filePath);
        }
        using (StreamWriter streamWriter = new StreamWriter(File.OpenWrite(filePath)))
        {
            streamWriter.Write(contentBuilber.ToString());
        }
    }
}