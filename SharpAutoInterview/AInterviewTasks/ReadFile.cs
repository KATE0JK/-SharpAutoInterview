using System.Reflection;

namespace InterviewTasks;

public class TimeoutException : Exception
{
    private readonly int timeout;
    
    public TimeoutException(int timeout)
    {
        this.timeout = timeout;
    }
    
    public string ErrorMessage
    {
        get
        {
            return "Unable to read file within timeout {0}" + timeout;
        }
    }
}

public class ReadFile
{
    public string GetFileContent(string path, int timeout)
    {
        if (File.Exists(path))
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(File.OpenRead(path)))
                {
                    streamReader.BaseStream.ReadTimeout = timeout * 1000;

                    string content = streamReader.ReadToEnd();

                    return content;
                }
                
            }

            catch
            {
                throw new Exception("Unable to read file within timeout {0}" + timeout);
            }
        }

        throw new Exception("File does not exist");
    }
}