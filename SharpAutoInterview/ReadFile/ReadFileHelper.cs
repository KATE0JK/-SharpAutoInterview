namespace ReadFile;

public class ReadFileHelper
{
    private static string _path = "NewFile.txt";
    private static string content = File.ReadAllText(_path);

    private string[] array = content.Split(new char[] { '.', '!', '?' });

    public void PutALineInFile()
    {
        for (int i = 0; i < array.Length; i++)
        {
            string newFile = "OutputText_" + (i + 1);
            // File.Create(@"../" + newFile);  // Создаст в папке на уровень выше
           
            using (StreamWriter writer = new StreamWriter(File.Create(@"./" + newFile)))  // Создаст в текущем, где запущено приложение.
            {
                writer.WriteLine(array[i]);
            }

            using (StreamReader reader = new StreamReader(File.Open(@"./" + newFile, FileMode.Open)))
            {
                var line = reader.ReadLine();
            }
        }
    }

}